using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26133_library.Creators
{
    public class PhoneCreator : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            Phone phone = new Phone();
            phone.Category = category;
            phone.Id = 3;
            phone.Price = 443;
            phone.ProductName = "phone";
            return phone;
        }
    }
}
