using System.Collections.Generic;
using System;

namespace _26114_library
{
    public class Director
    {
        private IProduct prod;

        Dictionary<Type, ProductCreater> DictCreat; 
          
       
        public IProduct CreateProduct<T>() where T : IProduct, new()
        {
            prod = DictCreat[typeof(T)].CreaterProduct();
            return prod;
        }

        public Director()
        {
            DictCreat = new Dictionary<Type, ProductCreater>();
            DictCreat.Add(typeof(PhoneAukva), new PhoneAukvaCreator());
            DictCreat.Add(typeof(PhoneBlack), new PhoneBlackCreator());
            DictCreat.Add(typeof(PhoneDualSim), new PhoneDualSimCreator());
            DictCreat.Add(typeof(PhoneSmartfon), new PhoneSmartfonCreator());
        
        }

    }



}
