using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

namespace YmsgStub.Server;

/// <summary>
/// libs/ 中的游戏 DLL 文件名带前缀（Library.Assembly-CSharp.dll、Metadata.Google.Protobuf.dll），
/// 与程序集名（Assembly-CSharp、Google.Protobuf）不一致，.NET 运行时按程序集名找不到它们，
/// 结果是所有引用 Msg.* 的 handler 类型加载失败、被 Scrutor 静默跳过（"0 handlers registered"）。
/// 这里在默认加载失败时，到输出目录按 "*.{程序集名}.dll" 再找一次。
/// </summary>
internal static class GameAssemblyResolver
{
    // 模块初始化器先于 Main 执行，保证在任何用到 Msg.* / Google.Protobuf 的代码之前注册
    [ModuleInitializer]
    internal static void Register() =>
        AssemblyLoadContext.Default.Resolving += (context, name) =>
        {
            var path = Directory
                .EnumerateFiles(AppContext.BaseDirectory, $"*.{name.Name}.dll")
                .FirstOrDefault(p => AssemblyName.GetAssemblyName(p).Name == name.Name);
            return path is null ? null : context.LoadFromAssemblyPath(path);
        };
}
