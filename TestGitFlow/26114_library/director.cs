namespace _26114_library
{
    public class Director
    {
        private IProduct prod;
        public IProduct CreateProduct<T>(int id, double price) where T : IProduct, new()
        {
            prod = new T ();
            return prod;
        }
    }



    //public class DocumentManager
    //{
    //    private IDocStorage _storage;

    //    public void SetStorage<T>() where T : IDocStorage, new()
    //    {
    //        this._storage = new T();
    //        // TODO: Setup, test, or do something else with the storage, if required.
    //    }
    //}



}
