using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26133_library.Creators
{
    public class ComputerCreator : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            Computer computer = new Computer();
            computer.Category = category;
            computer.Id = 4;
            computer.Price = 225;
            computer.ProductName = "computer";
            return computer;
        }
    }
}
