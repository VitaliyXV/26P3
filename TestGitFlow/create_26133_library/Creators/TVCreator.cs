using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26133_library.Creators
{
    public class TVCreator : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            TV tv = new TV();
            tv.Category = category;
            tv.Id = 1;
            tv.Price = 34;
            tv.ProductName = "TV";
            return tv;
        }
    }
}
