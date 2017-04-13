using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _26130_library.Product;
using _26130_library.Factory;

namespace _26130_library.Factory
{
    public class CreatorApple : CreatorProduct
    {
        public override IProduct CreatePhone(int id, int price)
        {
            return new PhoneToo
            {
                Id = id,
                Price = price
            };
        }
       
    }
}
