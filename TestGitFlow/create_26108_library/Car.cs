using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26108_library
{
    public class Car: IProduct
    {
        public int Id
        {
            get;

            set;

        }

        public int Price
        {
            get;

            set;

        }

        CategoryType type { get { return CategoryType.Car; } }    
    }
}
