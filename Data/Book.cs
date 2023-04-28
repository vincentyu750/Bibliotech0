﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Data
{
	public class Book
	{
		//[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Title { get; set; }
		public string AuthorFirstName { get; set; }
		public string AuthorLastName { get; set; }
		public long Isbn { get; set; }
		public string Location { get; set; }

		public Book() { }

		public Book(int id, string title, string authorFirstName, string authorLastName, long isbn, string location)
		{
			ID = id;
			Title = title;
			AuthorFirstName = authorFirstName;
			AuthorLastName = authorLastName;
			Isbn = isbn;
			Location = location;
		}
	}

}
