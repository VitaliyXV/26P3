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

		private static Dictionary<Category, ProductCreator> hashCategory;
		private static Dictionary<Type, ProductCreator> hashType;

		public static IProduct CreateProduct(Category category)
		{
			

			return hashCategory[category].CreateProduct();
		}

		public static IProduct CreateProduct<T>()
		{
			return hashType[typeof(T)].CreateProduct();
		}


		public Director()
		{
			hashCategory = new Dictionary<Category, ProductCreator>();
			hashType = new Dictionary<Type, ProductCreator>();

			InitializeCategory();
			InitializeType();

			
		}

		private void InitializeCategory()
		{
			hashCategory.Add(Category.Phone, new PhoneCreator());
			hashCategory.Add(Category.Route, new RouteCreator());
			hashCategory.Add(Category.Computer, new ComputerCreator());
			hashCategory.Add(Category.Notebook, new NotebookCreator());
			hashCategory.Add(Category.Keyboard, new KeyboardCreator());

		}

		private void InitializeType()
		{
			hashType.Add(typeof(PhoneCreator), new PhoneCreator());
			hashType.Add(typeof(RouteCreator), new RouteCreator());
			hashType.Add(typeof(ComputerCreator), new ComputerCreator());
			hashType.Add(typeof(NotebookCreator), new NotebookCreator());
			hashType.Add(typeof(KeyboardCreator), new KeyboardCreator());

		}
	}
}
