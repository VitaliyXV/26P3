using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26130_library.Product
{
   public class PhoneToo : IProduct
    {
       public int Id { get; set; }

       public int Price { get; set; }

        public Phone Category { get { return Phone.Apple; }  }
    }
}
