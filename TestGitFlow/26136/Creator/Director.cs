using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _26136.Model;

namespace _26136.Creator
{
    public class Director
    {
        public static IProduct CreateProduct(CategoryType type,int id,int price)
        {
            IProduct product = null;
            ProductCreator cr;

            switch (type)
            {
                case CategoryType.Food:
                    cr = new SaladCreator();
                    product = cr.CreateProduct(id,price);
                    break;
                case CategoryType.ElectricalEngineering:
                    cr = new ComputerCreator();
                    product = cr.CreateProduct(id,price);
                    break;
                case CategoryType.Clothing:
                     cr = new ShirtCreator();
                    product = cr.CreateProduct(id,price);
                   break;
                case CategoryType.Furniture:
                     cr = new SofaCreator();
                    product = cr.CreateProduct(id,price);
                    break;
                case CategoryType.Games:
                    cr = new BoardGamesCreator();
                    product = cr.CreateProduct(id,price);
                    break;
                default:
                    break;
            }

            return product;
        }
    }
}
