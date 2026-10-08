using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Msg;
using YmsgStub.Server.Models;

namespace YmsgStub.Server.Data;

/// <summary>
/// 角色存档，持久化到本地 JSON 文件（默认 saves/players.json，相对于项目目录，
/// 可用 Player:SaveFile 配置）。
/// 单机场景下不按账号区分角色：AccessToken 每次登录都可能变化，按它分区会让已建角色"消失"。
/// </summary>
public sealed class PlayerStore
{
    private const ulong FirstPlayerId = 100001;

    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        WriteIndented = true,
        // 角色名直接以中文写入，便于手工查看 / 修改存档
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
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
    /// 其余数值保持默认值。
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
            Save();
            return player;
        }
    }

    public void UpdateLastLogin(PlayerData player, long time)
    {
        lock (_lock)
        {
            player.LastLogin = time;
            Save();
        }
    }

    private static List<PlayerData> Load(string path)
    {
        if (!File.Exists(path)) return new List<PlayerData>();
        try
        {
            return JsonSerializer.Deserialize<List<PlayerData>>(File.ReadAllText(path), _jsonOptions)
                ?? new List<PlayerData>();
        }
        catch (JsonException ex)
        {
            // 不能当作空存档继续运行：下一次保存会把原文件覆盖掉
            throw new InvalidOperationException($"存档文件 {path} 解析失败，请修复或删除后重启", ex);
        }
    }

    // 先写临时文件再替换，避免写到一半崩溃时损坏存档；调用方需持有 _lock
    private void Save()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(_savePath)!);
        var tmp = _savePath + ".tmp";
        File.WriteAllText(tmp, JsonSerializer.Serialize(_players, _jsonOptions));
        File.Move(tmp, _savePath, overwrite: true);
    }
}
