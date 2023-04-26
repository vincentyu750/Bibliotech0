using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Data
{
	public abstract class Book
	{
		private string title;
		private string authorFirstName;
		private string authorLastName;
		private int isbn;
		private string location;

		//class constructor
		public Book(string title, string authorFirstName, string authorLastName, int isbn, string location)
		{
			this.title = title;
			this.authorFirstName = authorFirstName;
			this.authorLastName = authorLastName;
			this.isbn = isbn;
			this.location = location;
		}

		//getters & setters
		public string Title { get => title; set => title = value; }
		public string AuthorFirstName { get => authorFirstName; set => authorFirstName = value; }
		public string AuthorLastName { get => authorLastName; set => authorLastName = value; }
		public int Isbn { get => isbn; set => isbn = value; }
		public string Location { get => location; set => location = value; }

	}
}
