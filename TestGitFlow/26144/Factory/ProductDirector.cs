using _26144.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144.Factory
{
    public class ProductDirector
    {
        private static Dictionary<Category, ProductCreator> productCreators = new Dictionary<Category, ProductCreator>();

        public ProductDirector()
        {
            Initialize();
        }

        private void Initialize()
        {
            productCreators.Add(Category.Phone, new PhoneCreator());
            productCreators.Add(Category.TV, new TVCreator());
            productCreators.Add(Category.Climate, new ClimateCreator());
            productCreators.Add(Category.Kitchen, new KitchenCreator());
            productCreators.Add(Category.Accessories, new AccessoriesCreator());
        }

        public static IProduct CreateProduct(Category category, int id, int price)
        {
            return productCreators[category].CreateProduct(id, price);
        }
    }
}