using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Data
{
	public interface Searchable
	{
		// method - search for objects (users or books) based on the user's/staff's input
		List<object> Search(string keyword);
	}
}
