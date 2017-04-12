using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26131_library
{
    public class Switoch:IProduct
    {

        public int Id
        {
            get { return 2; }
        }

        public int Price
        {
            get { return 27; }
        }

        public Chocolate Category
        {
            get { return Chocolate.Switoch; }
        }
    }
}
