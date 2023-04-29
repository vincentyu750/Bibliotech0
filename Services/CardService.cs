using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotech0.Data;
using Bibliotech0.Interface;

namespace Bibliotech0.Services
{
	public class CardService : ICardService
	{
		public List<Cardholder> CardHolders { get; set; }
        public Cardholder CurrentCardHolder { get; set; }

        public CardService()
		{
            CardHolders = new List<Cardholder>
            {
                new Cardholder("Vincent", "Yu", "vincent.yu@sait.com", "123", "555-555-5555", 123456789, 50.0, false),
                new Cardholder("John", "Doe", "johndoe@example.com", "password123", "555-555-5555", 123456789, 50.0, false)
            };
        }

    }
}
