using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26114_library
{
    public class Phone : IProduct
    {
        public int Id { get { return Id; } private set { Id = value; } }

        public double Price { get { return Price; } private set { Price = value; } }

        public type Type { get { return Type; } private set { Type = value; } }

        public Phone(int Id, double Price, type Type)
        {
            this.Id = Id;
            this.Price = Price;
            this.Type = Type;
        }
    }
}
