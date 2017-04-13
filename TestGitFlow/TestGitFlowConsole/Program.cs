using create_26113_library;
using create_26113_library.Builder;
using create_26113_library.Factory;
using System;

namespace TestGitFlowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct prod = Director.CreateProductG<Laptop>();
            Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

            prod = Director.CreateProduct(Categories.PC);
            Console.WriteLine("{0} >> Price : {1} $", prod, prod.Price);

        }
    }
}
