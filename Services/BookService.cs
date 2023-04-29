using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotech0.Database;
using Bibliotech0.Data;
using Bibliotech0.Services;
using Bibliotech0.Interface;

namespace Bibliotech0.Services
{
	public class BookService : IBookService
	{
		public List<LoanableBook> BorrowedBooks { get; set; }

		public BookService()
		{
			BorrowedBooks = new List<LoanableBook>();
		}
	}
}
