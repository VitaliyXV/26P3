using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134.Factory
{
    public class BerryFactory : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            Berry berry = new Berry();
            return berry;
        }
    }
}
