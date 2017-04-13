using create_26113_library.Factory;
using System;

namespace create_26113_library.Builder
{
    public class Director
    {
        public static IProduct CreateProduct(Categories category)
        {
            IProduct someProduct = null;
            ICreator someCreator = null;
            switch (category)
            {
                case Categories.Laptop:
                    someCreator = new CreatorLaptop();
                    someProduct = someCreator.CreateProduct();
                    break;
                case Categories.PC:
                    someCreator = new CreatorPC();
                    someProduct = someCreator.CreateProduct();
                    break;
                case Categories.Phone:
                    someCreator = new CreatorPhone();
                    someProduct = someCreator.CreateProduct();
                    break;
                case Categories.Smartphone:
                    someCreator = new CreatorSmartphone();
                    someProduct = someCreator.CreateProduct();
                    break;
                case Categories.Tablet:
                    someCreator = new CreatorTablet();
                    someProduct = someCreator.CreateProduct();
                    break;
                default:
                    throw new Exception("Category is undefined");
                    break;
            }
            return someProduct;
        }
    }
}
