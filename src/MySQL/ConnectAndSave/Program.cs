namespace ConnectAndSave;

/// <summary>
/// メインプログラムクラス
/// </summary>
class Program
{
    static void Main()
    {
        using var context = new AppDbContext();
        context.Database.EnsureCreated();

        // データを追加する
        var user = new User { Name = "HogeFuga", Email = "pyon.co.jp" };
        context.Users.Add(user);
        context.SaveChanges();

        Console.WriteLine("Data added !");
    }
}