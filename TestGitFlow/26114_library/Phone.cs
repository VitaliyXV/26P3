using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26114_library
{
    public class Phone : IProduct
    {
        public int Id { get; private set; }

        public double Price { get; private set; }

        public type Type { get; private set; }

        public Phone(int Id, double Price, type Type)
        {
            this.Id = Id;
            this.Price = Price;
            this.Type = Type;
        }
    }
}
