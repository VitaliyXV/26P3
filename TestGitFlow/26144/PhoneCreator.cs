using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144
{
    public class PhoneCreator : ProductCreator
    {
        public override IProduct CreateProduct(int id, int price)
        {
            return new Phone(id, price);
        }
    }
}