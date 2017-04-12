using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26114_library
{
    public interface IProduct
    {
        int Id { get; }
        double Price { get; }
        type Type { get; }

    }

    public enum type {
        smartfon,
        phone,
        dual_sim,
        aukva,
        black
    }
}
