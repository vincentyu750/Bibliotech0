using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Data
{
	// manages instances of cardholder and staff
	public abstract class User
	{
		private string firstName;
		private string lastName;
		private string email;
		private string password;
		private string phone;

		public User(string firstName, string lastName, string email, string password, string phone)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.email = email;
			this.password = password;
			this.phone = phone;
		}

		public string FirstName { get =>  firstName; set => this.firstName = value;}
		public string LastName { get => lastName; set => this.lastName = value;}
		public string Email { get => email; set => this.email = value;}
		public string Password { get => password; set => this.password = value;}
		public string Phone { get => phone; set => this.phone = value;}
	}
}
