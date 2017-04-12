using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26133_library
{
    class Phone : IProduct
    {

        public Category Category { get; set; }

        public int Id { get; set; }

        public int Price { get; set; }

        public string ProductName { get; set; }
    }
}
