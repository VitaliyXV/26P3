using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26136.Model
{
    class Computer : IProduct
    {
        public int Id { get; set; }

        public int Price { get; set; }

        public Category Type { get; set; }
    }
}
