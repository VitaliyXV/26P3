using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26136.Model
{
    public enum Category
    {
        Apple,
        Samsung,
        Vertu,
        Nokia,
        Meizu
    }

    interface IProduct 
    {
        int Id { get; }
        int Price { get; }
        Category Type { get; }
    }
}
