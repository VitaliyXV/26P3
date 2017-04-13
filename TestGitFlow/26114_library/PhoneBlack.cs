namespace _26114_library
{
    public class PhoneBlack : IProduct
    {
        public int Id { get; private set; }

        public double Price { get; private set; }

        public type Type { get; private set; }

        //public PhoneBlack(int Id, double Price)
        public PhoneBlack()
        {
            //this.Id = Id;
            //this.Price = Price;
            this.Type = type.black;
        }
    }
}
