using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26130_library.Product
{
    public class PhoneThree : IProduct
    {
        public int Id { get { return 3; }  }

        public int Price { get { return 1500; }  }

        public Phone Category { get { return Phone.Nokia; }  }
    }
}
