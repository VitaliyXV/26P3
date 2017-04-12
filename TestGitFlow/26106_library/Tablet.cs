
namespace _26106_library
{
    class Tablet : IProduct
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
            get { return Categories.Tablet; }
            set
            {
                Category = value;
            }
        }
    }
}
