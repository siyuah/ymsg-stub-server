using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Msg;
using YmsgStub.Server.Models;

namespace YmsgStub.Server.Data;

/// <summary>
/// 角色存档，持久化到本地 JSON 文件（默认 saves/players.json，相对于内容根目录，
/// 即启动时的工作目录；用 dotnet run 启动时就是项目目录。可用 Player:SaveFile 配置）。
/// 存档只在启动时读取，之后整体覆盖写入：手工修改存档前请先停止服务器。
/// 单机场景下不按账号区分角色：AccessToken 每次登录都可能变化，按它分区会让已建角色"消失"。
/// </summary>
public sealed class PlayerStore
{
    private const ulong FirstPlayerId = 100001;
    private const int MoveRetries = 3;

    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        WriteIndented = true,
        // 角色名直接以中文写入，便于手工查看 / 修改存档
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true,
    };

    private readonly object _lock = new();
    private readonly List<PlayerData> _players;
    private readonly string _savePath;
    private readonly ILogger<PlayerStore> _logger;
    private readonly uint _initialMapId;
    private readonly float _initialPosX;
    private readonly float _initialPosY;

    public PlayerStore(IConfiguration config, IHostEnvironment env, ILogger<PlayerStore> logger)
    {
        _logger = logger;
        _initialMapId = config.GetValue<uint>("Player:InitialMapId");
        _initialPosX  = config.GetValue<float>("Player:InitialPosX");
        _initialPosY  = config.GetValue<float>("Player:InitialPosY");
        _savePath = Path.Combine(env.ContentRootPath,
            config["Player:SaveFile"] ?? Path.Combine("saves", "players.json"));

        _players = Load(_savePath);
        _logger.LogInformation("PlayerStore: {Count} players loaded from {Path}",
            _players.Count, _savePath);
    }

    public IReadOnlyList<PlayerData> All()
    {
        lock (_lock) return _players.ToList();
    }

    public PlayerData? Find(ulong playerId)
    {
        lock (_lock) return _players.Find(p => p.PlayerId == playerId);
    }

    /// <summary>
    /// 按客户端的创角选择生成一个 1 级角色并写盘。只填客户端选择的外观 / 职业和出生位置，
    /// 其余数值保持默认值。写盘失败时撤销创建并抛出异常。
    /// </summary>
    public PlayerData Create(CreatePlayer req, long now)
    {
        if (_initialMapId == 0)
            _logger.LogWarning("Player:InitialMapId 未配置（=0），客户端可能无法加载地图；" +
                "请在 appsettings.json 中填入客户端地图配置表中的有效地图 ID");

        lock (_lock)
        {
            ulong id = _players.Count == 0 ? FirstPlayerId : _players.Max(p => p.PlayerId) + 1;
            var player = new PlayerData
            {
                PlayerId       = id,
                Name           = string.IsNullOrEmpty(req.PlayerName) ? $"玩家{id}" : req.PlayerName,
                Level          = 1,
                Job            = (int)req.Job,
                Gender         = (int)req.Gender,
                Country        = (int)req.Country,
                Hairstyle      = req.Hairstyle,
                HairstyleColor = req.HairstyleColor,
                MapId          = _initialMapId,
                PosX           = _initialPosX,
                PosY           = _initialPosY,
                LastLogin      = now,
            };
            _players.Add(player);
            try { Save(); }
            catch
            {
                // 否则这个未落盘的角色会留在内存里，并在下一次成功保存时被一起写入
                _players.Remove(player);
                throw;
            }
            return player;
        }
    }

    /// <summary>
    /// 进入地图前更新角色：记录登录时间；出生地图为 0（创建时 Player:InitialMapId 还没配置）
    /// 的角色改用当前配置的出生点。写盘失败只记日志，不影响进入游戏。
    /// </summary>
    public void PrepareEnterMap(PlayerData player, long now)
    {
        lock (_lock)
        {
            player.LastLogin = now;
            if (player.MapId == 0 && _initialMapId != 0)
            {
                player.MapId = _initialMapId;
                player.PosX  = _initialPosX;
                player.PosY  = _initialPosY;
            }

            try { Save(); }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                _logger.LogWarning(ex, "PlayerStore: 写入存档 {Path} 失败，本次改动只保留在内存中", _savePath);
            }
        }
    }

    private static List<PlayerData> Load(string path)
    {
        if (!File.Exists(path)) return new List<PlayerData>();

        List<PlayerData?> players;
        try
        {
            players = JsonSerializer.Deserialize<List<PlayerData?>>(File.ReadAllText(path), _jsonOptions)
                ?? new List<PlayerData?>();
        }
        catch (JsonException ex)
        {
            // 不能当作空存档继续运行：下一次保存会把原文件覆盖掉
            throw new InvalidOperationException($"存档文件 {path} 解析失败，请修复或删除后重启", ex);
        }

        // 手工编辑可能留下空条目或重复 ID，启动时就拒绝，而不是等到登录时出错
        if (players.Any(p => p is null || p.PlayerId == 0)
            || players.Select(p => p!.PlayerId).Distinct().Count() != players.Count)
            throw new InvalidOperationException(
                $"存档文件 {path} 中有空条目、PlayerId 为 0 或重复的角色，请修复后重启");

        foreach (var player in players)
            player!.Name ??= string.Empty;
        return players!;
    }

    // 先写临时文件并刷到磁盘，再替换正式文件，避免写到一半崩溃或断电时损坏存档；调用方需持有 _lock
    private void Save()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(_savePath)!);
        var tmp = _savePath + ".tmp";
        using (var file = new FileStream(tmp, FileMode.Create, FileAccess.Write))
        {
            JsonSerializer.Serialize(file, _players, _jsonOptions);
            file.Flush(flushToDisk: true);
        }

        // Windows 上杀毒软件 / 同步盘可能短暂占用存档文件，替换失败时稍等重试
        for (int attempt = 1; ; attempt++)
        {
            try
            {
                File.Move(tmp, _savePath, overwrite: true);
                return;
            }
            catch (Exception ex) when (attempt < MoveRetries
                && ex is IOException or UnauthorizedAccessException)
            {
                Thread.Sleep(100);
            }
        }
    }
}
