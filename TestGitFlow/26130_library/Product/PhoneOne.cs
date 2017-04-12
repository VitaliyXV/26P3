using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26130_library.Product
{
    public class PhoneOne : IProduct
    {
        public int Id {get { return 1; } }

        public int Price { get { return 1000; }  }

        public Phone Category { get {return Phone.HTC; }  }
    }
}
