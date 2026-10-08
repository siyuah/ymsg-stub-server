# ymsg-stub-server

本地 stub 服务器，用于将《英雄三国》（YMSG）客户端改造为可离线运行的单机游戏。

## 项目结构

```
ymsg-stub-server/
├── YmsgStub.Server/
│   ├── Network/                        # TCP（游戏协议）
│   │   ├── GameServer.cs               # TCP 监听 + 连接管理
│   │   ├── ClientSession.cs            # 单连接收发包处理
│   │   ├── PacketRouter.cs             # msgId → handler 路由表
│   │   ├── IMessageHandler.cs          # handler 接口
│   │   └── MessageHandlerBase.cs       # 泛型 Protobuf handler 基类
│   ├── Http/                           # HTTP（登录前的区服查询）
│   │   ├── HttpGateway.cs              # 解封 HttpTransMsg，按 MsgID 分发
│   │   ├── IHttpMessageHandler.cs      # handler 接口
│   │   └── HttpMessageHandlerBase.cs   # 泛型 Protobuf handler 基类
│   ├── Handlers/
│   │   ├── GetAllRegionHandler.cs      # HTTP 9000  区服列表
│   │   ├── GetRegionLoginServerHandler.cs # HTTP 9002 区服 TCP 地址
│   │   ├── AppHeartBeatHandler.cs      # TCP 8      心跳
│   │   ├── AccountLoginHandler.cs      # TCP 9020   账号登录，返回角色列表
│   │   ├── CreatePlayerHandler.cs      # TCP 9013   创建角色
│   │   ├── GetServerTimeHandler.cs     # TCP 10000  服务器时间
│   │   ├── EnterMapHandler.cs          # TCP 11005  进入地图（进入游戏）
│   │   └── EnterMapFinishHandler.cs    # TCP 11006  地图加载完成
│   ├── Data/
│   │   └── PlayerStore.cs              # 角色存档读写（本地 JSON 文件）
│   ├── Models/
│   │   └── PlayerData.cs               # 角色存档模型 ↔ PlayerBase / PlayerSelf
│   ├── MsgIds.cs                       # 消息 ID（Msg.MSGID2CS 真实值）
│   ├── MsgIdCatalog.cs                 # 读取 DLL 中的 MSGID 枚举：--dump-msgids / 日志翻译
│   ├── GameAssemblyResolver.cs         # 让运行时找到带前缀的游戏 DLL
│   ├── ServerClock.cs                  # 服务器时间（按客户端时间戳推断秒/毫秒）
│   └── Program.cs                      # 服务启动入口（HTTP + TCP）
├── libs/                               # 本地游戏 DLL（不提交 git）
│   ├── Metadata.Google.Protobuf.dll
│   └── Library.Assembly-CSharp.dll
└── docs/
    └── proto_analysis.md               # 从客户端 DLL 提取的完整协议分析
```

## 快速开始

1. 将游戏 DLL 复制到 `libs/`（见 .gitignore，不随源码提交）：
   ```
   libs/Metadata.Google.Protobuf.dll
   libs/Library.Assembly-CSharp.dll
   ```

2. 按下文「配置」修改 `appsettings.json`，至少填好 `Player:InitialMapId`。

3. 运行服务器：
   ```bash
   cd YmsgStub.Server
   dotnet run
   ```
   同时监听 HTTP `0.0.0.0:8080` 和 TCP `0.0.0.0:8888`。

4. 把客户端的登录地址（`GameGlobalSetting.GetLoginUrl()`）指向 `http://<本机 IP>:8080`。
   路径任意，服务器只看 body 里的 MsgID。TCP 地址不用改：客户端会从 GetRegionLoginServer 的应答里拿到。

## 配置（appsettings.json）

| 键 | 默认值 | 说明 |
|---|---|---|
| `Server:Port` | 8888 | TCP 游戏端口 |
| `Server:HttpPort` | 8080 | HTTP 登录端口 |
| `Server:PublicHost` | 127.0.0.1 | GetRegionLoginServer 告诉客户端的 TCP 地址；客户端在手机 / 模拟器上时改成本机局域网 IP |
| `Region:Id` | 1 | 区服 ID，需是客户端区服配置表中存在的 ID |
| `Region:Status` | 0 | 区服状态（SERVER_STATUS 的整数值，各值含义未知） |
| `Player:InitialMapId` | 0 | 新角色出生地图，需取自客户端地图配置表；为 0 时客户端很可能无法加载地图 |
| `Player:InitialPosX` / `InitialPosY` | 0 | 新角色出生坐标 |
| `Player:SaveFile` | saves/players.json | 角色存档，相对于项目目录 |

## 当前状态

- [x] TCP 服务器框架、Protobuf 收发、Handler 路由
- [x] 消息 ID 真实值（Msg.MSGID2CS）
- [x] HTTP 登录接口：GetAllRegion / GetRegionLoginServer
- [x] 登录流程：AppHeartBeat / GetServerTime / AccountLogin / CreatePlayer / EnterMap / EnterMapFinish
- [x] 角色存档持久化（本地 JSON）
- [ ] 新角色出生地图 ID（`Player:InitialMapId`）
- [ ] HTTP 账号登录（RequestToken / LoginAccount）、GetAllPlayer，以及删除角色（DeletePlayer / CancelDeletePlayer）
- [ ] 进入地图后客户端请求的各模块数据（背包、技能、任务……）

## 消息 ID

`MsgIds.cs` 中的值取自客户端唯一的消息 ID 枚举 `Msg.MSGID2CS`，C→S 与 S→C 共用一套 ID：

- 无 `Ntf` 后缀：客户端请求。服务器的应答**使用与请求相同的 ID**（如 AccountLogin 请求和
  AccountLoginAck 应答都是 9020），body 类型是对应的 `XxxAck`。`MessageHandlerBase` 默认如此。
- `Ntf` 后缀：服务器主动推送，body 类型一般是去掉 Ntf 后的 `XxxAck`（如 AddBuffNtf ↔ AddBuffAck）。

需要更多 ID 时，把游戏 DLL 放进 `libs/` 后运行 `dotnet run -- --dump-msgids` 导出完整枚举。
服务器启动时会把每个 handler 的 msgId 对照该枚举打印出来；收到没有 handler 的消息时，
日志会给出它在枚举中的名字，便于确认客户端下一步需要什么。

## 登录流程

```
客户端                                 stub
  │── HTTP GetAllRegion (9000) ─────────▶│  返回一个区服（Region:Id）
  │── HTTP GetRegionLoginServer (9002) ─▶│  返回 TCP 地址 PublicHost:Port
  │═════════════ 连接 TCP ═══════════════│
  │── AppHeartBeat (8) ─────────────────▶│  原样回传（周期性）
  │── GetServerTime (10000) ────────────▶│  回传 ClientTime + 服务器时间
  │── AccountLogin (9020) ──────────────▶│  不校验 token，返回存档中的全部角色
  │◀───────────────── AccountLoginAck ───│  （列表为空 → 客户端进入创角界面）
  │── CreatePlayer (9013) ──────────────▶│  1 级角色写入存档，外观/职业/国家沿用客户端选择
  │◀───────────────── CreatePlayerAck ───│
  │── EnterMap (11005) ─────────────────▶│  选角是客户端行为，选中后直接 EnterMap
  │◀───────────────────── EnterMapAck ───│  BaseInfo / SelfInfo（出生地图与坐标）
  │── EnterMapFinish (11006) ───────────▶│  客户端加载完场景后发送
  │◀──────────── EnterMapFinishNtfAck ───│
```

HTTP 请求与应答的 body 都是 `Msg.HttpTransMsg { MsgID, MsgBody }`，MsgBody 为内层 protobuf。
这是依据协议中的 HttpTransMsg 类型推断的；格式不符时，HttpGateway 会把请求的路径和 body 的
十六进制预览记入日志。

Ack 只填最小数据：RetCode=0、ID / 名字 / 等级 / 出生位置，以及所有子消息给空实例
（proto3 中未设置的子消息在客户端解析后为 null，访问其成员会 NRE）。

## 协议说明

TCP 包格式（待客户端抓包确认）：
```
[4 bytes] 包总长度（含头部 8 字节）
[4 bytes] 消息 ID (uint32, big-endian)
[N bytes] Protobuf body
```

完整消息类型列表见 [docs/proto_analysis.md](docs/proto_analysis.md)（1037 个消息类型）。
