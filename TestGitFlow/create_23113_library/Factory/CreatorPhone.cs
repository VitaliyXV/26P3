namespace create_26113_library.Factory
{
    public class CreatorPhone : ICreator
    {
        public IProduct CreateProduct()
        {
            return new Phone { Price = 50 };
        }
    }
}
