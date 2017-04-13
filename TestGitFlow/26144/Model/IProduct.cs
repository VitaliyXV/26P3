using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144.Model
{
    public interface IProduct
    {
        int Id { get; }
        int Price { get; set; }
        Category Category { get; }

    }
}