using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26139
{
	class Route : IProduct
	{
		public int Id
		{
			get;
			private set;
		}

		public int Price
		{
			get;
			set;
		}

		public Category Category
		{
			get { return Category.Phone; }
		}

		public Route()
		{

		}
	}
}
