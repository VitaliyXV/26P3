namespace create_26113_library.Factory
{
    public class CreatorPC : ICreator
    {
        public IProduct CreateProduct()
        {
            return new PC { Price = 750 };
        }
    }
}
