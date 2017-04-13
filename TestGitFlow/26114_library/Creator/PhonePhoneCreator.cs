namespace _26114_library
{
    class PhonePhoneCreator : ProductCreater
    {
        public override IProduct CreaterProduct()
        {
            return new PhonePhone();
        }
    }
}
