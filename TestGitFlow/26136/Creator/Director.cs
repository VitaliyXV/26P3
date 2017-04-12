using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _26136.Model;

namespace _26136.Creator
{
    public static class Director
    {
        private static Dictionary<CategoryType, ProductCreator> ProductCreaters = new Dictionary<CategoryType, ProductCreator>();

        static Director()
        {
            ProductCreaters.Add(CategoryType.Clothing, new ShirtCreator());
            ProductCreaters.Add(CategoryType.ElectricalEngineering, new ComputerCreator());
            ProductCreaters.Add(CategoryType.Food, new SaladCreator());
            ProductCreaters.Add(CategoryType.Furniture, new SofaCreator());
            ProductCreaters.Add(CategoryType.Games, new BoardGamesCreator());
        }

       


        public static IProduct CreateProduct(CategoryType type,int id,int price)
        {
            ProductCreator cr;
            IProduct product = null;

            cr = ProductCreaters[type];
            switch (type)
            {
                case CategoryType.Food:
                    product = cr.CreateProduct(id,price);
                    break;
                case CategoryType.ElectricalEngineering:
                    cr = new ComputerCreator();
                    product = cr.CreateProduct(id,price);
                    break;
                case CategoryType.Clothing:
                    product = cr.CreateProduct(id,price);
                   break;
                case CategoryType.Furniture:
                    product = cr.CreateProduct(id,price);
                    break;
                case CategoryType.Games:
                    product = cr.CreateProduct(id,price);
                    break;
                default:
                    break;
            }

            return product;
        }
    }
}
