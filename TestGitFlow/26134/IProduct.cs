using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26134
{
    public interface IProduct
    {
        int Id { get;  }
        float Price { get; }
        Category category { get;  }
    }

    public enum Category
    {
        vegetables,
        fruits,
        berries,
        meats,
        sweetFeed
    }
}
