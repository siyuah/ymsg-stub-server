using YmsgStub.Server.Network;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<PacketRouter>();
builder.Services.AddSingleton<GameServer>();
builder.Services.AddHostedService(sp => sp.GetRequiredService<GameServer>());

// 注册所有 handler（按模块扫描）
builder.Services.Scan(scan => scan
    .FromAssemblyOf<Program>()
    .AddClasses(c => c.AssignableTo<IMessageHandler>())
    .AsImplementedInterfaces()
    .WithSingletonLifetime());

var host = builder.Build();

// 初始化路由表
var router = host.Services.GetRequiredService<PacketRouter>();
router.RegisterAll(host.Services);

await host.RunAsync();
