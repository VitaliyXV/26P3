using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134
{
    public class Meat : IProduct
    {
        public int Id
        {
            get
            {
                return 3;
            }
        }

        public Category category
        {
            get
            {
                return Category.meats;
            }
        }

        public float Price
        {
            get
            {
                return (float)999.99;
            }
        }
    }
}
