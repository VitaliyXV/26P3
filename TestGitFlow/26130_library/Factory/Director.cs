using _26130_library.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26130_library.Factory
{
    public static class Director
    {
        private static Dictionary<Phone, CreatorProduct> PhoneCreater = new Dictionary<Phone, CreatorProduct>();


        static Director()
        {
            PhoneCreater.Add(Phone.Apple, new CreatorApple());
            PhoneCreater.Add(Phone.HTC, new CreateHTC());
            PhoneCreater.Add(Phone.Nokia, new CreateNokia());
            PhoneCreater.Add(Phone.Samsung, new CreateSamsung());
            PhoneCreater.Add(Phone.Sony, new CreateSony());
        }




    }
}
