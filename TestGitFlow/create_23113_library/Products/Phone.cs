namespace create_26113_library
{
    public class Phone : IProduct
    {
        public int Id { get; protected set; }

        public int Price { get; set; }

        public Categories Category
        {
            get { return Categories.Phone; }
        }
    }
}
