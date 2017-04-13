using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144
{
    public abstract class ProductCreator
    {
        public abstract IProduct CreateProduct(int id, int price);
    }
}