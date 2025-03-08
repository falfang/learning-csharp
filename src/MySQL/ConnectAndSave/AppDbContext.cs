using Microsoft.EntityFrameworkCore;

namespace ConnectAndSave;

/// <summary>
/// データベースコンテキスト
/// </summary>
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "server=localhost;database=testdb;user=root;password=mypass",
            new MySqlServerVersion(new Version(8, 0, 41))
            );
    }
}
