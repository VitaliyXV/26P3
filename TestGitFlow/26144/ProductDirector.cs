using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144
{
    public class ProductDirector
    {
        public static IProduct CreateProduct(Category category, int id, int price)
        {
            ProductCreator creator = null;
            switch (category)
            {
                case Category.Phone:
                    creator = new PhoneCreator();
                    return creator.CreateProduct(id, price);
                case Category.TV:
                    creator = new TVCreator();
                    return creator.CreateProduct(id, price);
                case Category.Climate:
                    creator = new ClimateCreator();
                    return creator.CreateProduct(id, price);
                case Category.Kitchen:
                    creator = new KitchenCreator();
                    return creator.CreateProduct(id, price);
                case Category.Accessories:
                    creator = new AccessoriesCreator();
                    return creator.CreateProduct(id, price);
                default:
                    return null;
            }
        }
    }
}