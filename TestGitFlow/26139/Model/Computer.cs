using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26139.Model
{
	class Computer : IProduct
	{
		public Category Category
		{
			get { return Category.Computer; }
		}

<<<<<<< HEAD:TestGitFlow/26139/Model/Computer.cs
		public int Id
		{
			get;
			private set;
		}
=======
        public int Id
        {
            get;

            set;
        }
>>>>>>> develop:TestGitFlow/26139/Computer.cs

		public int Price
		{
			get;

			set;
		}
	}
}
