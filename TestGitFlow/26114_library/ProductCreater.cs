using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26114_library
{
    public abstract class ProductCreater
    {
        public virtual IProduct CreaterProduct(){throw new System.NotImplementedException();}
    }
}
