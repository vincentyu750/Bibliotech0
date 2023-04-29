using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Data
{
	public class Library
	{
		private string locationName;

		public Library(string locationName) 
		{
			this.locationName = locationName;
		}
		public string LocationName { get => locationName; set => this.locationName = value; }
	}

	
}
