﻿namespace _26114_library
{
    public class PhoneDualSim : IProduct
    {
        public int Id { get; private set; }

        public double Price { get; private set; }

        public type Type { get; private set; }

        public PhoneDualSim()
        {
           this.Type = type.dual_sim;
        }

        public PhoneDualSim(int Id, double Price)
        {
            this.Id = Id;
            this.Price = Price;
            this.Type = type.dual_sim;
        }


    }
}
