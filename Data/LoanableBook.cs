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
		private bool isAvailable;
		private string genre;
		private int borrowedByCard;

		//class constructor
		public LoanableBook(string title, string authorFirstName, string authorLastName, int isbn, string location, string borrowDate, string returnDate, bool isAvailable, string genre, int borrowedByCard) : base(title, authorFirstName, authorLastName, isbn, location)
		{
			this.borrowDate = borrowDate;
			this.returnDate = returnDate;
			this.isAvailable = isAvailable;
			this.genre = genre;
			this.borrowedByCard = borrowedByCard;
		}

		//getters & setters
		public string BorrowDate { get =>  borrowDate; set => borrowDate = value; }
		public string ReturnDate { get => returnDate; set => returnDate = value; }
		public bool IsAvailable { get => isAvailable; set => isAvailable = value; }
		public string Genre { get => genre; set => genre = value; }
		public int BorrowedByCard { get => borrowedByCard; set => borrowedByCard = value; }

	}
}
