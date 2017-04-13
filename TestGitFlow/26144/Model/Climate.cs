using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26144.Model
{
    class Climate : IProduct
    {
        public int Id { get; private set; }
        public int Price { get; set; }
        public Category Category { get; private set; }

        public void Cool()
        {
            Console.WriteLine("Cool this room");
        }

        public void Warm()
        {
            Console.WriteLine("Warm this room");
        }

        public Climate(int id, int price)
        {
            Id = id;
            Price = price;
            Category = Category.Phone;
        }

        public override string ToString()
        {
            return string.Format("Id:{0}, Price = {1}, Category = {2}", Id, Price, Category);
        }
    }
}