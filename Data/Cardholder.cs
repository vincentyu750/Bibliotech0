using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Data
{
	public class Cardholder : User
	{
		private int cardNumber;
		private double balance;
		private bool itemsOnLoan;

		//class constructor
		public Cardholder(string firstName, string lastName, string email, string password, string phone, int cardNumber, double balance, bool itemsOnLoan) : base(firstName, lastName, email, password, phone)
		{
			this.cardNumber = cardNumber;
			this.balance = balance;
			this.itemsOnLoan = itemsOnLoan;
		}

		//getters & setters
		public int CardNumber { get => cardNumber; set => cardNumber = value; }
		public double Balance { get => balance; set => balance = value; }
		public bool ItemsOnLoan { get => itemsOnLoan; set => itemsOnLoan = value; }

	}
}
