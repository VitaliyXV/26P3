namespace create_26113_library.Factory
{
    public class CreatorSmartphone : ICreator
    {
        public IProduct CreateProduct()
        {
            return new Smartphone { Price = 299 };
        }
    }
}
