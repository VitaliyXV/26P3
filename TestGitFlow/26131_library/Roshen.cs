using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26131_library
{
    public class Roshen:IProduct
    {
        public int Id { get { return 5; } }
        public int Price { get { return 23; } }
        public Chocolate Category { get { return Chocolate.Roshen; } }
    }
}
