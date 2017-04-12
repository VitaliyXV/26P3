using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _26106_library;

namespace TestGitFlowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct phone = new Phone();
            phone.Id = 1;
            phone.Price = 700;
            phone.Category = Categories.Phone;

            Console.WriteLine("{0}.{1} - phone ${2}", phone.Id, phone.Category, phone.Price);
        }
    }
}
