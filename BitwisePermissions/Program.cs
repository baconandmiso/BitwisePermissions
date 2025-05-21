using net.kinoemon.BitwisePermissions;

Permissions permissions = Permissions.MESSAGE_SEND | Permissions.MESSAGE_READ; // 権限を付与する
Console.WriteLine($"与えられた権限: {permissions} / 値: {(int)permissions}");

bool canSend = (permissions & Permissions.MESSAGE_SEND) != 0;
Console.WriteLine($"メッセージが送信可能か: {canSend} / 値: {(int)permissions}");

permissions |= Permissions.VIEW_CHANNEL; // 権限を追加する
Console.WriteLine($"追加後: {permissions} / 値: {(int)permissions}");

permissions &= ~Permissions.MESSAGE_READ; // 権限を削除する
Console.WriteLine($"削除後: {permissions} / 値: {(int)permissions}");