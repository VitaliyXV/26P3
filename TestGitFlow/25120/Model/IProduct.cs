using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25120
{
    public interface IProduct
    {
        int id { get; set;}
        double price { get; set; }
        Category category { get;}
    }
}
