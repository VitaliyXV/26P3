using create_26113_library.Factory;
using System;

namespace create_26113_library.Builder
{
    //IProduct prod = Director.CreateProductG<Laptop>();
    //Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

    //prod = Director.CreateProduct(Categories.PC);
    //Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

    public class Director
    {
        static IProduct someProduct = null;
        static ICreator someCreator = null;

        public static IProduct CreateProduct(Categories category)
        {
            someProduct = null;
            someCreator = null;
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

        public static IProduct CreateProductG<T>()
        {
            someProduct = null;
            someCreator = null;

            if (typeof(T) == typeof(Laptop))
            {
                someCreator = new CreatorLaptop();
                someProduct = someCreator.CreateProduct();
            }
            else
            if (typeof(T) == typeof(PC))
            {
                someCreator = new CreatorPC();
                someProduct = someCreator.CreateProduct();
            }
            else
            if (typeof(T) == typeof(Phone))
            {
                someCreator = new CreatorPhone();
                someProduct = someCreator.CreateProduct();
            }
            else
            if (typeof(T) == typeof(Smartphone))
            {
                someCreator = new CreatorSmartphone();
                someProduct = someCreator.CreateProduct();
            }
            else
            if (typeof(T) == typeof(Tablet))
            {
                someCreator = new CreatorTablet();
                someProduct = someCreator.CreateProduct();
            }
            else throw new Exception("Category is undefined");
            return someProduct;
        }
    }
}
