using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134
{
    class Berry : IProduct
    {
        public int Id
        {
            get
            {
                return 4;
            }
        }

        public Category category
        {
            get
            {
                return Category.berries;
            }
        }

        public float Price
        {
            get
            {
                return (float)1009.99;
            }
        }
    }
}
