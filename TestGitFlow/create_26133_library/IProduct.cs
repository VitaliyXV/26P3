using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26133_library
{
    public  interface IProduct
    {
        int Id { get; set; }
        int Price { get; set; }
        Category Category { get; set; }
        string ProductName { get; set; }
    }
}
