using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Data
{
	public class LoanableBook : Book
	{
		private string borrowDate;
		private string returnDate;
		private string isAvailable;

		// class constructor
		public LoanableBook(int id, string title, string authorFirstName, string authorLastName, long isbn, string location, string borrowDate, string returnDate, string isAvailable)
			: base(id, title, authorFirstName, authorLastName, isbn, location, isAvailable)
		{
			this.borrowDate = borrowDate;
			this.returnDate = returnDate;
			this.isAvailable = "Yes"; // set isAvailable to true by default
		}

		// getters & setters
		public string BorrowDate { get => borrowDate; set => borrowDate = value; }
		public string ReturnDate { get => returnDate; set => returnDate = value; }
	}
}