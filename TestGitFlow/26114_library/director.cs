using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26114_library
{
    public class Director
    {
        private IProduct prod;
        public IProduct CreateProduct<T>() where T : new()
        {

            prod = new Phone(1, 2.3, type.aukva);
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
