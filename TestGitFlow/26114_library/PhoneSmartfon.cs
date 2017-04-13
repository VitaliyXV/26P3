﻿namespace _26114_library
{
    public class PhoneSmartfon : IProduct
    {
        public int Id { get; private set; }

        public double Price { get; private set; }

        public type Type { get; private set; }

        public PhoneSmartfon()
        {
            this.Type = type.smartfon;
        }

        public PhoneSmartfon(int Id, double Price)
        {
            this.Id = Id;
            this.Price = Price;
            this.Type = type.smartfon;
        }
    }
}
