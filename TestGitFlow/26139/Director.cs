using _26139.Model;
using _26139.Factory;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26139
{
	public class Director
	{
		public static IProduct CreateProduct(Category category)
		{
			IProduct product = null;
			ProductCreator creator = null;
			switch (category)
			{
				case _26139.Model.Category.Phone:
					creator = new PhoneCreator();
					product = creator.CreateProduct();
					break;
				case _26139.Model.Category.Route:
					creator = new RouteCreator();
					product = creator.CreateProduct();
					break;
				case _26139.Model.Category.Computer:
					creator = new ComputerCreator();
					product = creator.CreateProduct();
					break;
				case _26139.Model.Category.Notebook:
					creator = new NotebookCreator();
					product = creator.CreateProduct();
					break;
				case _26139.Model.Category.Keyboard:
					creator = new KeyboardCreator();
					product = creator.CreateProduct();
					break;
			}

			return product;
		}

	}
}
