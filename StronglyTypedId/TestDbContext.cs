using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Options;

namespace StronglyTypedId
{
    internal class TestDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = "Server=192.168.2.252;database=test1;uid=root;pwd=1q2wazsx;";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
            optionsBuilder.UseMySql(connStr, serverVersion);
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<AuthorId>().HaveConversion<AuthorIdConverter>();
            configurationBuilder.Properties<BookId>().HaveConversion<BookIdConverter>();
        }

        private class AuthorIdConverter : ValueConverter<AuthorId, long>
        {
            public AuthorIdConverter()
                : base(v => v.Value, v => new(v))
            {
            }
        }

        private class BookIdConverter : ValueConverter<BookId, Guid>
        {
            public BookIdConverter()
                : base(v => v.Value, v => new(v))
            {
            }
        }

    }
}
