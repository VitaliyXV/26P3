using _26136.Model;
using System;

namespace _26136.Creator
{
    public abstract class ProductCreator
    {
        public abstract IProduct CreateProduct(int id, int price);
    }
}
