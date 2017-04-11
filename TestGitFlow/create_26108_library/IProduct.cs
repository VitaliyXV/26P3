using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26108_library
{
    interface IProduct
    {
        int Id { get; set; }
        int Price { get; set; }
        enum Categoryes
        { 
            Phone,
            Car, 
            Window,
            Food,
            Boots
        }
    }
}
