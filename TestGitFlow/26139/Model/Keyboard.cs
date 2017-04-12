using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26139.Model
{
	class Keyboard : IProduct
	{
		public Category Category
		{
			get { return Category.Keyboard; }
		}

<<<<<<< HEAD:TestGitFlow/26139/Model/Keyboard.cs
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
>>>>>>> develop:TestGitFlow/26139/Keyboard.cs

		public int Price
		{
			get;
			set;
		}
	}
}
