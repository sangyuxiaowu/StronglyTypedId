using Microsoft.EntityFrameworkCore;

namespace ordinary
{
    internal class TestDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = "Server=192.168.1.6;database=test;uid=root;pwd=1q2wazsx;";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
            optionsBuilder.UseMySql(connStr, serverVersion);
            optionsBuilder.LogTo(Console.WriteLine);
        }

    }
}
