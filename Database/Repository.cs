using Microsoft.EntityFrameworkCore;
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Bibliotech0.Data;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Linq;

namespace Bibliotech0.Database
{
    public class Repository : DbContext
    {
        private readonly string _dbPath;

        public Repository()
        {
            _dbPath = Path.Combine(new DirectoryInfo(AppContext.BaseDirectory).Parent.Parent.Parent.Parent.Parent.FullName, "Database", "LibraryDatabase.db");
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_dbPath}");
        }

        public async Task<List<Book>> BookListAsync()
        {
            try
            {
                return await Books.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
