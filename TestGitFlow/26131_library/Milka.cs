using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26131_library
{
    public class Milka:IProduct
    {
        public int Id { get { return 4; } }
        public int Price { get { return 38; } }
        public Chocolate Category { get { return Chocolate.Milka; } }
    }
}
