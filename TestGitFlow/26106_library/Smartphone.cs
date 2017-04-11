
namespace _26106_library
{
    class Smartphone : IProduct
    {
        public int Id
        {
            get { return Id; }
            protected set
            {
                Id = value;
            }
        }

        public int Price
        {
            get { return Price; }
            protected set
            {
                Price = value;
            }
        }

        public Categories Category
        {
            get { return Categories.Smartphone; }
            protected set
            {
                Category = value;
            }
        }
    }
}
