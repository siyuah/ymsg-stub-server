using System.Reflection;

namespace YmsgStub.Server;

/// <summary>
/// 读取客户端 DLL 中的 MSGID* 枚举（如 Msg.MSGID2CS）。
/// 用途：
///   1. <c>dotnet run -- --dump-msgids</c> 导出真实消息 ID，用来回填 <see cref="MsgIds"/>；
///   2. 日志里把数字 msgId 翻译成枚举名，便于对照客户端实际发出的消息。
/// </summary>
public static class MsgIdCatalog
{
    private sealed record Entry(string EnumName, string Name, string? ProtoName, long Value);

    private static readonly Lazy<List<Type>> _enumTypes = new(FindEnumTypes);
    private static readonly Lazy<ILookup<long, Entry>> _byValue =
        new(() => _enumTypes.Value.SelectMany(GetEntries).ToLookup(e => e.Value));

    /// <summary>DLL 中是否找到了 MSGID* 枚举。</summary>
    public static bool IsAvailable
    {
        get
        {
            try { return _enumTypes.Value.Count > 0; }
            catch (Exception) { return false; }
        }
    }

    /// <summary>把 msgId 翻译成 "MSGID2CS.Xxx"；DLL 中没有对应项时返回 null。</summary>
    public static string? Describe(uint msgId)
    {
        try
        {
            var names = _byValue.Value[msgId].Select(e => $"{e.EnumName}.{e.Name}").ToList();
            return names.Count == 0 ? null : string.Join(" / ", names);
        }
        // DLL 读不出枚举时只是日志里少了名字，不影响收发包
        catch (Exception) { return null; }
    }

    /// <summary>
    /// 按 docs/proto_analysis.md 的格式输出所有 MSGID* 枚举，可直接补进文档「消息 ID」一节。
    /// 返回进程退出码。
    /// </summary>
    public static int Dump(TextWriter output)
    {
        var enums = _enumTypes.Value;
        output.WriteLine($"# 由 `dotnet run -- --dump-msgids` 从 {GameAssembly().Location} 导出");
        output.WriteLine();

        if (enums.Count == 0)
        {
            output.WriteLine("未找到名字含 MSGID 的枚举。成员最多的枚举（候选）：");
            var candidates = LoadableTypes()
                .Where(t => t.IsEnum)
                .Select(t => (Type: t, Count: Enum.GetNames(t).Length))
                .OrderByDescending(c => c.Count)
                .Take(10);
            foreach (var (type, count) in candidates)
                output.WriteLine($"  {type.FullName}  ({count} 项)");
            return 1;
        }

        foreach (var type in enums)
        {
            var entries = GetEntries(type).OrderBy(e => e.Value).ToList();
            output.WriteLine($"## {type.FullName}  (IsEnum=True, {entries.Count} 项)");
            foreach (var e in entries)
                output.WriteLine($"  {e.Name,-48} = {e.Value,-8}{(e.ProtoName is null ? "" : $"  // {e.ProtoName}")}");
            output.WriteLine();
        }
        return 0;
    }

    private static Assembly GameAssembly() => typeof(Msg.AccountLogin).Assembly;

    private static IEnumerable<Type> LoadableTypes()
    {
        // 真实的 Assembly-CSharp 依赖 UnityEngine 等不在 libs/ 中的程序集，
        // 部分类型加载失败是正常的；枚举类型没有这些依赖，能正常取到。
        try { return GameAssembly().GetTypes(); }
        catch (ReflectionTypeLoadException ex) { return ex.Types.OfType<Type>(); }
    }

    private static List<Type> FindEnumTypes() => LoadableTypes()
        .Where(t => t.IsEnum && t.Name.Contains("MSGID", StringComparison.OrdinalIgnoreCase))
        .OrderBy(t => t.FullName, StringComparer.Ordinal)
        .ToList();

    private static IEnumerable<Entry> GetEntries(Type enumType) => enumType
        .GetFields(BindingFlags.Public | BindingFlags.Static)
        .Select(f => new Entry(enumType.Name, f.Name, OriginalName(f),
            Convert.ToInt64(f.GetRawConstantValue())));

    // protoc 生成的枚举成员带 [OriginalName("PROTO_NAME")]；按名字匹配特性，
    // 不依赖特定版本的 Google.Protobuf 里是否有这个类型。
    private static string? OriginalName(FieldInfo field) =>
        field.CustomAttributes
            .FirstOrDefault(a => a.AttributeType.Name == "OriginalNameAttribute")
            ?.ConstructorArguments.FirstOrDefault().Value as string;
}
