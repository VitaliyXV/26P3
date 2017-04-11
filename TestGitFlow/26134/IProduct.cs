using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134
{
    public interface IProduct
    {
        int Id { get; set; }
        float Price { get; set; }
        Category Phone { get; set; }
    }

    public enum Category
    {
        FiveClass,
        FivePlan
    }
}
