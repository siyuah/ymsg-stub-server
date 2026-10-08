# ymsg-stub-server

本地 stub 服务器，用于将《英雄三国》（YMSG）客户端改造为可离线运行的单机游戏。

## 项目结构

```
ymsg-stub-server/
├── YmsgStub.Server/
│   ├── Network/
│   │   ├── GameServer.cs          # TCP 监听 + 连接管理
│   │   ├── ClientSession.cs       # 单连接收发包处理
│   │   ├── PacketRouter.cs        # msgId → handler 路由表
│   │   ├── IMessageHandler.cs     # handler 接口
│   │   └── MessageHandlerBase.cs  # 泛型 Protobuf handler 基类
│   ├── Handlers/
│   │   ├── AccountLoginHandler.cs # 账号登录，返回角色列表
│   │   ├── CreatePlayerHandler.cs # 创建角色
│   │   ├── EnterMapHandler.cs     # 进入地图（进入游戏）
│   │   └── GetServerTimeHandler.cs# 服务器时间
│   ├── Data/
│   │   └── PlayerStore.cs         # 角色存档（目前仅内存，持久化待实现）
│   ├── Models/                    # 游戏数据模型（待实现）
│   ├── MsgIds.cs                  # 消息 ID 常量（占位，见下文「消息 ID」）
│   ├── MsgIdCatalog.cs            # 读取 DLL 中的 MSGID 枚举：--dump-msgids / 日志翻译
│   ├── GameAssemblyResolver.cs    # 让运行时找到带前缀的游戏 DLL
│   ├── ServerClock.cs             # 服务器时间（按客户端时间戳推断秒/毫秒）
│   └── Program.cs                 # 服务启动入口
├── libs/                          # 本地游戏 DLL（不提交 git）
│   ├── Metadata.Google.Protobuf.dll
│   └── Library.Assembly-CSharp.dll
└── docs/
    └── proto_analysis.md          # 从客户端 DLL 提取的完整协议分析
```

## 快速开始

1. 将游戏 DLL 复制到 `libs/`（见 .gitignore，不随源码提交）：
   ```
   libs/Metadata.Google.Protobuf.dll
   libs/Library.Assembly-CSharp.dll
   ```

2. 导出真实消息 ID 并回填 `MsgIds.cs`（见下文「消息 ID」）。

3. 在 `appsettings.json` 的 `Player:InitialMapId` / `InitialPosX` / `InitialPosY`
   填入新角色的出生地图和坐标（需取自客户端地图配置表；为 0 时客户端很可能无法加载地图）。

4. 运行服务器：
   ```bash
   cd YmsgStub.Server
   dotnet run
   ```
   默认监听 `0.0.0.0:8888`，可在 `appsettings.json` 中修改。

5. 修改客户端连接地址，指向 `127.0.0.1:8888`。

## 当前状态

- [x] TCP 服务器框架
- [x] Protobuf 包收发
- [x] Handler 路由系统
- [x] 登录流程 handler：AccountLogin / CreatePlayer / EnterMap / GetServerTime
- [ ] 消息 ID 真实值（运行 `--dump-msgids` 导出后回填）
- [ ] 新角色出生地图 ID（`Player:InitialMapId`）
- [ ] 角色存档持久化、删除角色（DeletePlayer / CancelDeletePlayer）
- [ ] 各功能模块 handler

## 消息 ID

`docs/proto_analysis.md` 的「消息 ID」一节只导出了 `MsgIdCsReflection` 等描述符容器类，
没有枚举值。真正的枚举是 `MSGID2CS`（客户端 `NetworkManager.RegisterMessageHandler(MSGID2CS msgID, ...)`
的参数类型）。把游戏 DLL 放进 `libs/` 后运行：

```bash
cd YmsgStub.Server
dotnet run -- --dump-msgids
```

即按文档格式列出 DLL 中所有名字含 `MSGID` 的枚举及其数值，按结果替换 `MsgIds.cs` 中的占位值。
服务器启动时也会把每个 handler 的 msgId 对照该枚举打印出来；收到没有 handler 的消息时，
日志会给出它在枚举中的名字，便于确认客户端实际发出的消息。

## 登录流程

```
客户端                         stub
  │── GetServerTime ─────────────▶│  回传 ClientTime + 服务器时间
  │── AccountLogin ──────────────▶│  不校验 token，返回内存中的全部角色
  │◀──────────── AccountLoginAck ─│  （列表为空 → 客户端进入创角界面）
  │── CreatePlayer ──────────────▶│  1 级角色，外观/职业/国家沿用客户端选择
  │◀──────────── CreatePlayerAck ─│
  │── EnterMap(PlayerID) ────────▶│  选角是客户端行为，选中后直接 EnterMap
  │◀─────────────── EnterMapAck ──│  BaseInfo / SelfInfo
  │◀────── EnterMapFinishNtfAck ──│  紧跟 Ack 推送（时机待抓包确认）
```

协议里没有 SelectRole / EnterGame / EnterScene，对应的是客户端选角后直接发送的 EnterMap。
Ack 只填最小数据：RetCode=0、ID / 名字 / 等级 / 出生位置，以及所有子消息给空实例
（proto3 中未设置的子消息在客户端解析后为 null，访问其成员会 NRE）。

客户端在连上本服务器之前还有一段 HTTP 登录（`LoginModule.HttpLogin` / `PostWebRequest`，
以及 `GetAllRegion` / `GetRegionLoginServer` 等区服查询），这部分不在本 stub 内。

## 协议说明

包格式（待客户端抓包确认）：
```
[4 bytes] 包总长度（含头部 8 字节）
[4 bytes] 消息 ID (uint32, big-endian)
[N bytes] Protobuf body
```

完整消息类型列表见 [docs/proto_analysis.md](docs/proto_analysis.md)（1037 个消息类型）。
