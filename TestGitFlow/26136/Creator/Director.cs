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

        private static Dictionary<Type, ProductCreator> ProductCreatersTypes = new Dictionary<Type, ProductCreator>();

        static Director()
        {
            ProductCreaters.Add(CategoryType.Clothing, new ShirtCreator());
            ProductCreaters.Add(CategoryType.ElectricalEngineering, new ComputerCreator());
            ProductCreaters.Add(CategoryType.Food, new SaladCreator());
            ProductCreaters.Add(CategoryType.Furniture, new SofaCreator());
            ProductCreaters.Add(CategoryType.Games, new BoardGamesCreator());


            ProductCreatersTypes.Add(typeof(Sofa), new SofaCreator());
            ProductCreatersTypes.Add(typeof(Shirt), new ShirtCreator());
            ProductCreatersTypes.Add(typeof(Salad), new SaladCreator());
            ProductCreatersTypes.Add(typeof(BoardGames), new BoardGamesCreator());
            ProductCreatersTypes.Add(typeof(Computer), new ComputerCreator());
        }

       


        public static IProduct CreateProduct<T>(CategoryType type,int id,int price)
        {
            return ProductCreaters[type].CreateProduct(id, price);
        }


        public static IProduct Create<T>(CategoryType type, int id, int price)
        {
            return ProductCreatersTypes[typeof(T)].CreateProduct(id, price);
        }
    }
}
