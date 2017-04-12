using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26130_library.Product
{
    public interface IProduct
    {
        int Id {get; }
        int Price { get;  }
        Phone Category { get;  }
    }
}
