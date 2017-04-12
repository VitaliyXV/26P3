using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26139.Model
{
	class Notebook : IProduct
	{
		public Category Category
		{
			get { return Category.Notebook; }
		}

<<<<<<< HEAD:TestGitFlow/26139/Model/Notebook.cs
		public int Id
		{
			get;
			protected set;
		}
=======
        public int Id
        {
            get;
            set;
        }
>>>>>>> develop:TestGitFlow/26139/Notebook.cs

		public int Price
		{
			get;
			set;
		}
	}
}
