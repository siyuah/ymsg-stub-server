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
│   │   └── AccountLoginHandler.cs # 第一个实现：账号登录
│   ├── Data/                      # 存档/状态持久化（待实现）
│   ├── Models/                    # 游戏数据模型（待实现）
│   ├── MsgIds.cs                  # 消息 ID 常量（占位，待抓包确认）
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

2. 运行服务器：
   ```bash
   cd YmsgStub.Server
   dotnet run
   ```
   默认监听 `0.0.0.0:8888`，可在 `appsettings.json` 中修改。

3. 修改客户端连接地址，指向 `127.0.0.1:8888`。

## 当前状态

- [x] TCP 服务器框架
- [x] Protobuf 包收发
- [x] Handler 路由系统
- [x] AccountLogin 占位 handler
- [ ] 消息 ID 真实值（需抓包或进一步反射 MsgIdCs.proto 描述符）
- [ ] 角色创建 / 进入游戏流程
- [ ] 各功能模块 handler

## 协议说明

包格式（待客户端抓包确认）：
```
[4 bytes] 包总长度（含头部 8 字节）
[4 bytes] 消息 ID (uint32, big-endian)
[N bytes] Protobuf body
```

完整消息类型列表见 [docs/proto_analysis.md](docs/proto_analysis.md)（1037 个消息类型）。
