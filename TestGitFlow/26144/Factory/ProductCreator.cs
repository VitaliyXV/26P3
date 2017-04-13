using _26144.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144.Factory
{
    public abstract class ProductCreator
    {
        public abstract IProduct CreateProduct(int id, int price);
    }
}