using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144
{
    public class Phone : IProduct
    {
        public int Id { get; private set; }
        public int Price { get; set; }
        public Category Category { get; private set; }

        public void RingToMother()
        {
            Console.WriteLine("Allo, Mother!");
        }
    }
}