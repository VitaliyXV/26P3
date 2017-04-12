using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26136.Model
{
    public enum CategoryType
    {
        Food,
        ElectricalEngineering,
        Сlothing,
        Furniture,
        Games
    }

   public interface IProduct 
    {
        int Id { get; }
        int Price { get; }
        CategoryType Type { get; }
    }
}
