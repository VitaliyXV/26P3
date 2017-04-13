using _26136.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26136.Creator
{
    public class ComputerCreator : ProductCreator
    {
        public override IProduct CreateProduct(int id, int price)
        {
            return new Computer
            {
                Id = id,
                Price = price
            };
        }
    }
}
