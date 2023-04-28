using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Data
{
	public interface Loanable
	{
		// method - check if the book is currently available for loan
		bool IsLoanable();

		// method - loan the book to a user
		void LoanBook(string userName);

		// method - return the book to the library
		void ReturnBook();

		// property - get the cardNumber or staffID of the user who has borrowed the item
		int UserID { get; }
	}
}
