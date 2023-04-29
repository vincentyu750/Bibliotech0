using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotech0.Database;
using Bibliotech0.Data;
using Bibliotech0.Services;

namespace Bibliotech0.Interface
{
	public interface IBookService
	{
		List<LoanableBook> BorrowedBooks { get; set; }

	}
}
