using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144
{
    public class ProductDirector
    {
        private static Dictionary<Category, ProductCreator> productCreators = new Dictionary<Category, ProductCreator>();
        public static IProduct CreateProduct(Category category, int id, int price)
        {
            ProductCreator creator = null;
            if (productCreators.ContainsKey(category))
            {
                creator = productCreators[category];
                return creator.CreateProduct(id, price);
            }
            else
            {
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
}