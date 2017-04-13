namespace create_26113_library.Factory
{
    public class CreatorTablet : ICreator
    {
        public IProduct CreateProduct()
        {
            return new Tablet { Price = 500 };
        }
    }
}
