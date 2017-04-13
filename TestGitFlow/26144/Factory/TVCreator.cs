using _26144.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144.Factory
{
    public class TVCreator : ProductCreator
    {
        public override IProduct CreateProduct(int id, int price)
        {
            return new TV(id, price);
        }
    }
}