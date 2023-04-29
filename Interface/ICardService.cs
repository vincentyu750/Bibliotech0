using Bibliotech0.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech0.Interface
{
	public interface ICardService
	{
		List<Cardholder> CardHolders { get; }
        Cardholder CurrentCardHolder { get; set; }
    }
}
