using _26139.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26139.Factory
{
	class ComputerCreator : ProductCreator
	{
		public override IProduct CreateProduct()
		{
			return new Computer() { Price = 140};
		}
	}
}
