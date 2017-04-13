namespace _26114_library
{
    class PhoneSmartfonCreator : ProductCreater
    {
        public override IProduct CreaterProduct()
        {
            return new PhoneSmartfon();
        }
    }
}
