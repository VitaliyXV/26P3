using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26131_library
{
    public interface IProduct
    {
        int Id { get; }
        int Price { get; }
        Chocolate Category { get; }
    }
}
