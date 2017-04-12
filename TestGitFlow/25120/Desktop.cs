using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25120
{
    public class Desktop : IProduct
    {
        public int id { get; set; }
        public double price { get; set; }
        public Category category { get; set; }
    }
}
