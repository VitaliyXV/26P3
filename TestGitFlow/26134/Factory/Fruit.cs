using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134.Factory
{
    public class FruitFactory : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            Fruit fruit = new Fruit();
            return fruit;
        }
    }
}
