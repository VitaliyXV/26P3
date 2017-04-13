namespace _26114_library
{
    public class PhoneSmartfon : IProduct
    {
        public int Id { get; private set; }

        public double Price { get; private set; }

        public type Type { get; private set; }

        //public PhoneSmartfon(int Id, double Price)
        public PhoneSmartfon()
        {
            //this.Id = Id;
            //this.Price = Price;
            this.Type = type.smartfon;
        }
    }
}
