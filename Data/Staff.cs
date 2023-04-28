using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Data
{
	internal class Staff : User
	{
		private int staffID;

		//class constructor
		public Staff(string firstName, string lastName, string email, string password, string phone, int staffID) : base(firstName, lastName, email, password, phone)
		{
			this.staffID = staffID;
		}

		//getters & setters
		public int StaffID { get => staffID; set => staffID = value; }

	}
}
