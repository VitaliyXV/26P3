using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26113_library
{
    public class Smartphone : IProduct
    {
        public int Id
        {
            get { return Id; }
            protected set { Id = value; }
        }

        public int Price
        {
            get { return Price; }
            protected set { Price = value; }
        }

        public Categories Category
        {
            get { return Categories.Smartphone ; }
        }
    }
}
