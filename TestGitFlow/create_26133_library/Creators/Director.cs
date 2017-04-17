using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26133_library.Creators
{
    public static class Director<Type> where Type : IProductFactory, new()
    {
       public static IProduct CreateProduct(Category category)
        {
            IProductFactory creator = new Type();
            return creator.CreateProduct(category);
        }
    }
}
