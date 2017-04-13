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
            //IProduct pr = Director.CreateProduct(CategoryType.Clothing, 1, 15);

            IProduct pr = Director.CreateProduct<Sofa>(CategoryType.Clothing, 1, 15);
            Console.WriteLine(pr.Price);
        }
    }
}
