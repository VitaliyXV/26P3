using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134
{
    public class SweatFood : IProduct
    {
        public int Id
        {
            get
            {
                return 5;
            }
        }

        public Category category
        {
            get
            {
                return Category.sweetFeed;
            }
        }

        public float Price
        {
            get
            {
                return (float)9999.99;
            }
        }
    }
}
