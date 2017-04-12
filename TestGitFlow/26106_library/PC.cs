
namespace _26106_library
{
    public class PC : IProduct
    {
        private int id;
        private int price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Categories Category
        {
            get { return Categories.PC; }           
        }

    }
}
