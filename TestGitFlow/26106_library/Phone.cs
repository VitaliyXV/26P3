
namespace _26106_library
{
    class Phone : IProduct
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
            get { return Categories.Phone; }
            protected set
            {
                Category = value;
            }
        }
    }
}
