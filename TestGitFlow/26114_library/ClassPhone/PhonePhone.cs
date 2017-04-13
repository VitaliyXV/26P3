namespace _26114_library
{
    public class PhonePhone : IProduct
    {
        public int Id { get; private set; }

        public double Price { get; private set; }

        public type Type { get; private set; }

        public PhonePhone()
        {
            this.Type = type.phone;
        }

        public PhonePhone(int Id, double Price)
        {

            this.Id = Id;
            this.Price = Price;
            this.Type = type.phone;
        }


    }
}
