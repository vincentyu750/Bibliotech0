using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Bibliotech0.Data;
using Microsoft.Data.Sqlite;


namespace Bibliotech0.Services
{
    public class FindBookService
    {
        static SQLiteAsyncConnection db;
        static string databasePath = Path.Combine(new DirectoryInfo(AppContext.BaseDirectory).Parent.Parent.Parent.Parent.Parent.FullName, "Database", "LibraryDatabase.db");

        static async Task Init()
        {

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Book>();
        }

        public static async Task<List<Book>> GetBooks()
        {
            await Init();
            List<Book> books = await db.Table<Book>().Where(b => b.ID > 0).ToListAsync();
            return books;
        }

        public static async Task AddBook(Book book)
        {
            await Init();
            await db.InsertAsync(book);
        }

        public static async Task RemoveBook(int isbn)
        {
            await Init();
            await db.DeleteAsync<Book>(isbn);
        }


    }
}

