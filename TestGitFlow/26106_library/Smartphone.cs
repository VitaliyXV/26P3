
namespace _26106_library
{
    class Smartphone : IProduct
    {
        public int Id
        {
            get { return Id; }
            set
            {
                Id = value;
            }
        }

        public int Price
        {
            get { return Price; }
            set
            {
                Price = value;
            }
        }

        public Categories Category
        {
            get { return Categories.Smartphone; }
            set
            {
                Category = value;
            }
        }
    }
}
