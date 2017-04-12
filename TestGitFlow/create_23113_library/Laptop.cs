using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26113_library
{
    public class Laptop : IProduct
    {
        public int Id
        {
            get;
            protected set;
        }

        public int Price
        {
            get;
            protected set;
        }

        public Categories Category
        {
            get { return Categories.Laptop; }
        }
    }
}
