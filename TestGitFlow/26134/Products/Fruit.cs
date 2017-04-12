using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134
{
    public class Fruit : IProduct
    {
        public int Id
        {
            get
            {
                return 1;
            }            
        }

        public Category category
        {
            get
            {
                return Category.fruits;
            }
        }

        public float Price
        {
            get
            {
                return (float)49.99;
            }
        }
    }
}
