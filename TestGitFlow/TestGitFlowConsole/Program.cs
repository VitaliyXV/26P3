
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitFlowConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Director dr = new Director();
            IProduct prod = dr.CreateProduct(1, 2.5, type.black);

        }
    }
}
