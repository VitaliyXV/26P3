using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134.Factory
{
    public class VegetableFactory : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            Vegetable vegetable = new Vegetable();
            return vegetable;
        }
    }
}
