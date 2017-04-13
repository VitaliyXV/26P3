using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134.Factory
{
    public class MeatFactory : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            Meat meat = new Meat();
            return meat;
        }
    }
}
