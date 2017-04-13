using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _26136.Model;

namespace _26136.Creator
{
    public class BoardGamesCreator : ProductCreator
    {
        public override IProduct CreateProduct(int id, int price)
        {
            return new BoardGames
            {
                Id = id,
                Price = price
            };
        }
    }
}
