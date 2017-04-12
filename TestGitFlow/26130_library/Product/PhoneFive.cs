using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26130_library.Product
{
    public  class PhoneFive : IProduct
    {
        public int Id { get { return 5; }  }

        public int Price { get { return 800; }  }

        public Phone Category { get { return Phone.Sony; }  }
    }
}
