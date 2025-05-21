namespace net.kinoemon.BitwisePermissions;

/// <summary>
/// 権限を表す列挙型
/// </summary>
[Flags]
public enum Permissions
{
    /// <summary>
    /// 権限なし
    /// </summary>
    NONE = 0,

    /// <summary>
    /// メッセージ送信
    /// </summary>
    MESSAGE_SEND = 1 << 0, // 1

    /// <summary>
    /// メッセージ読み取り
    /// </summary>
    MESSAGE_READ = 1 << 1, // 2

    /// <summary>
    /// チャンネル表示
    /// </summary>
    VIEW_CHANNEL = 1 << 2, // 4

    /// <summary>
    /// メッセージ管理
    /// </summary>
    MANAGE_MESSAGES = 1 << 3, // 8

    /// <summary>
    /// チャンネル管理
    /// </summary>
    MANAGE_CHANNELS = 1 << 4, // 16
    
    /// <summary>
    /// サーバー管理
    /// </summary>
    MANAGE_SERVER = 1 << 5 // 32
}