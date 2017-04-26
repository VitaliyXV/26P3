using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134
{
    public class Vegetable:IProduct
    {
        public int Id
        {
            get
            {
                return 2;
            }
        }

        public Category category
        {
            get
            {
                return Category.vegetables;
            }
        }

        public float Price
        {
            get
            {
                return (float)99.99;
            }
        }
    }
}
