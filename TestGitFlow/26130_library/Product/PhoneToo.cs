using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26130_library.Product
{
   public class PhoneToo : IProduct
    {
        public int Id { get { return 2; }  }

        public int Price { get { return 2000; }  }

        public Phone Category { get { return Phone.Apple; }  }
    }
}
