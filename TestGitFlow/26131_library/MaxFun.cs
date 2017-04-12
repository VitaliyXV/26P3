using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26131_library
{
    public class MaxFun:IProduct
    {
        public int Id { get { return 3; } }
        public int Price { get { return 45; } }
        public Chocolate Category { get { return Chocolate.MaxFun; } }
    }
}
