
namespace _26106_library
{
    class PC : IProduct
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
            get { return Categories.PC; }
            protected set
            {
                Category = value;
            }
        }

    }
}
