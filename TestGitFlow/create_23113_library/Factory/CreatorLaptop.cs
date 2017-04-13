namespace create_26113_library.Factory
{
    public class CreatorLaptop : ICreator
    {
        public IProduct CreateProduct()
        {
            return new Laptop { Price = 1970 };
        }
    }
}
