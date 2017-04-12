using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26130_library.Product
{
    public class PhoneFour : IProduct
    {
        public int Id { get { return 4; }  }

        public int Price { get { return 1800; }  }

        public Phone Category { get { return Phone.Samsung; }  }
    }
}
