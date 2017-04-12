using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26133_library.Creators
{
    public class TabletCreator : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            Tablet tablet = new Tablet();
            tablet.Category = category;
            tablet.Id = 2;
            tablet.Price = 122;
            tablet.ProductName = "tablet";
            return tablet;
        }
    }
}
