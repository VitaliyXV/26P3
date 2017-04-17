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
        private static Dictionary<Type, ProductCreator> productCreatorsT = new Dictionary<Type, ProductCreator>();

        public ProductDirector()
        {
            Initialize();
        }

        private void Initialize()
        {
            InitializeByCategory();
            InitializeByType();
        }

        private void InitializeByCategory()
        {
            productCreators.Add(Category.Phone, new PhoneCreator());
            productCreators.Add(Category.TV, new TVCreator());
            productCreators.Add(Category.Climate, new ClimateCreator());
            productCreators.Add(Category.Kitchen, new KitchenCreator());
            productCreators.Add(Category.Accessories, new AccessoriesCreator());
        }

        private void InitializeByType()
        {
            productCreatorsT.Add(typeof(PhoneCreator), new PhoneCreator());
            productCreatorsT.Add(typeof(TVCreator), new TVCreator());
            productCreatorsT.Add(typeof(ClimateCreator), new ClimateCreator());
            productCreatorsT.Add(typeof(KitchenCreator), new KitchenCreator());
            productCreatorsT.Add(typeof(AccessoriesCreator), new AccessoriesCreator());
        }

        public static IProduct CreateProduct(Category category, int id, int price)
        {
            return productCreators[category].CreateProduct(id, price);
        }

        public static IProduct CreateProduct<T>(int id, int price)
        {
            return productCreatorsT[typeof(T)].CreateProduct(id, price);
        }
    }
}