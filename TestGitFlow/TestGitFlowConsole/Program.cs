using System;
using _26136;
using _26136.Model;
using _26136.Creator;
namespace TestGitFlowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            IProduct prod = Director.CreateProductG<Smartphone>();
            Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

            prod = Director.CreateProduct(Categories.PC);
            Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

            prod = Director.CreateProductNew(Categories.Tablet);
            Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

            prod = Director.CreateProductG<Laptop>();
            Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);
=======
            //IProduct pr = Director.CreateProduct(CategoryType.Clothing, 1, 15);

            IProduct pr = Director.CreateProduct<Sofa>(CategoryType.Clothing, 1, 15);
            Console.WriteLine(pr.Price);
>>>>>>> develop
        }
    }
}
