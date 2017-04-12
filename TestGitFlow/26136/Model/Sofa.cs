using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26136.Model
{
    public class Sofa : IProduct
    {
        public int Id { get; set; }

        public int Price { get; set; }

        public CategoryType Type { get { return CategoryType.Furniture; } }
    }
}
