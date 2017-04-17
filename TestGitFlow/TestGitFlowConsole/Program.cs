using create_26133_library;
using create_26133_library.Creators;
using System;

namespace TestGitFlowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = Director<ComputerCreator>.CreateProduct(Category.xiomi);
            var product2 = Director<TVCreator>.CreateProduct(Category.samsung);
            var product3 = Director<PhoneCreator>.CreateProduct(Category.nokia);
            var product4 = Director<CameraCreator>.CreateProduct(Category.lg);
            Console.WriteLine(GetProduct(product1));
            Console.WriteLine(GetProduct(product2));
            Console.WriteLine(GetProduct(product3));
            Console.WriteLine(GetProduct(product4));
        }

        static private string GetProduct(IProduct product)
        {
            var str = product.ProductName + " Id: " + product.Id + " Price: " + product.Price + " Category: " + product.Category;
            return str;
        }
    }
}
