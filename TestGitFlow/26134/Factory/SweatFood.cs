using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134.Factory
{
    public class SweatFactory : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            SweatFood sweatFood = new SweatFood();
            return sweatFood;
        }
    }
}
