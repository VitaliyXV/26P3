using _26136.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26136.Creator
{
    public class ShirtCreator : ProductCreator
    {
        public override Model.IProduct CreateProduct(int id, int price)
        {
            return new Shirt
            {
                Id = id,
                Price = price
            };
        }

    }
}
