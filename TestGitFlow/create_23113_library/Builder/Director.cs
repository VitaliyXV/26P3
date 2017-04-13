using create_26113_library.Factory;
using System;
using System.Collections.Generic;

namespace create_26113_library.Builder
{
    //IProduct prod = Director.CreateProductG<Smartphone>();
    //Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

    //prod = Director.CreateProduct(Categories.PC);
    //Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

    //prod = Director.CreateProductNew(Categories.Tablet);
    //Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

    //prod = Director.CreateProductG<Laptop>();
    //Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

    public class Director
    {
        static IProduct someProduct = null;
        static ICreator someCreator = null;
        private static Dictionary<Type, ICreator> DictType = new Dictionary<Type, ICreator>();
        private static Dictionary<Categories, ICreator> DictCategory = new Dictionary<Categories, ICreator>();

        static Director()
        {
            initDictCategory();
            initDictType();
        }

        private static void  initDictCategory()
        {
            DictCategory.Add(Categories.Phone, new CreatorPhone());
            DictCategory.Add(Categories.Laptop, new CreatorLaptop());
            DictCategory.Add(Categories.Tablet, new CreatorTablet());
            DictCategory.Add(Categories.Smartphone, new CreatorSmartphone());
            DictCategory.Add(Categories.PC, new CreatorPC());
        }

        private static void initDictType()
        {
            DictType.Add(typeof(Phone), new CreatorPhone());
            DictType.Add(typeof(Laptop), new CreatorLaptop());
            DictType.Add(typeof(Tablet), new CreatorTablet());
            DictType.Add(typeof(Smartphone), new CreatorSmartphone());
            DictType.Add(typeof(PC), new CreatorPC());
        }

        static IProduct CreateProductGNew<T>()
        {
            return DictType[typeof(T)].CreateProduct();
        }

        public static IProduct CreateProductNew(Categories category)
        {
            return DictCategory[category].CreateProduct();
        }

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
