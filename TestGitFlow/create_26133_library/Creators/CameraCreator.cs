using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_26133_library.Creators
{
    public class CameraCreator : IProductFactory
    {
        public IProduct CreateProduct(Category category)
        {
            Camera camera = new Camera();
            camera.Category = category;
            camera.Id = 5;
            camera.Price = 456;
            camera.ProductName = "camera";
            return camera;
        }
    }
}
