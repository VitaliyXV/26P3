using create_26133_library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26133_library.Creators
{
    class Director
    {
        private Director(Devices device, Category category )
        {
            switch(device)
            {
                case Devices.Camera:
                    {
                        IProductFactory product = new CameraCreator();
                        product.CreateProduct(category);
                    }; break;
                case Devices.Computer:
                    {
                        IProductFactory product = new ComputerCreator();
                        product.CreateProduct(category);
                    }; break;
                case Devices.Phone:
                    {
                        IProductFactory product = new PhoneCreator();
                        product.CreateProduct(category);
                    }; break;
                case Devices.Tablet:
                    {
                        IProductFactory product = new TabletCreator();
                        product.CreateProduct(category);
                    }; break;
                case Devices.TV:
                    {
                        IProductFactory product = new TVCreator();
                        product.CreateProduct(category);
                    }; break;
            }
        }
    }
}
