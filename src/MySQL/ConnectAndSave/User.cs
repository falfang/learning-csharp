namespace ConnectAndSave;

/// <summary>
/// エンティティクラス
/// </summary>
public class User
{
    /// <summary>
    /// ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 名前
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// メールアドレス
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 作成時刻
    /// </summary>
    public DateTime Created_At { get; set; } = DateTime.Now;
}
