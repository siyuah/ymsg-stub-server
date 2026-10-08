using YmsgStub.Server;
using YmsgStub.Server.Data;
using YmsgStub.Server.Http;
using YmsgStub.Server.Network;

// dotnet run -- --dump-msgids：导出客户端 DLL 中的真实消息 ID 后退出
if (args.Contains("--dump-msgids"))
    return MsgIdCatalog.Dump(Console.Out);

var builder = WebApplication.CreateBuilder(args);

// HTTP 登录接口（GetAllRegion / GetRegionLoginServer），TCP 游戏服务器见 GameServer
builder.WebHost.ConfigureKestrel(kestrel =>
    kestrel.ListenAnyIP(builder.Configuration.GetValue("Server:HttpPort", 8080)));

builder.Services.AddSingleton<PacketRouter>();
builder.Services.AddSingleton<HttpGateway>();
builder.Services.AddSingleton<PlayerStore>();
builder.Services.AddSingleton<GameServer>();
builder.Services.AddHostedService(sp => sp.GetRequiredService<GameServer>());

// 注册所有 handler（TCP 与 HTTP，按模块扫描）
builder.Services.Scan(scan => scan
    .FromAssemblyOf<Program>()
    .AddClasses(c => c.AssignableToAny(typeof(IMessageHandler), typeof(IHttpMessageHandler)))
    .AsImplementedInterfaces()
    .WithSingletonLifetime());

var app = builder.Build();

// 初始化路由表
var router = app.Services.GetRequiredService<PacketRouter>();
router.RegisterAll(app.Services);

// 客户端请求的 URL 路径未知：所有 HTTP 请求都交给 HttpGateway，按 MsgID 分发
app.Run(app.Services.GetRequiredService<HttpGateway>().HandleAsync);

await app.RunAsync();
return 0;
