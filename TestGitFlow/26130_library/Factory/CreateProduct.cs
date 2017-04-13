using _26130_library.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26130_library.Factory
{
    public abstract class CreatorProduct
    {
        public abstract IProduct CreatePhone(int id, int price);


    }
}
