﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26139
{
	class Notebook : IProduct
	{
		public Category Category
		{
			get { return Category.Notebook; }
		}

        public int Id
        {
            get;
            set;
        }

		public int Price
		{
			get;

			set;
		}
	}
}
