﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26139
{
	class Keyboard : IProduct
	{
		public Category Category
		{
			get { return Category.Keyboard; }
		}

		public int Id
		{
			get;
		}

		public int Price
		{
			get;
			set;
		}
	}
}
