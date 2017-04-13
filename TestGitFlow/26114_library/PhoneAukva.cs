namespace _26114_library
{
    public class PhoneAukva : IProduct
    {
        public int Id { get; private set; }

        public double Price { get; private set; }

        public type Type { get; private set; }

        public PhoneAukva()
        {
            this.Type = type.aukva;
        }

        public PhoneAukva(int Id, double Price)
        {
            this.Id = Id;
            this.Price = Price;
            this.Type = type.aukva;
        }

    }
}
