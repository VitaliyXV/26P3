namespace _26114_library
{
    class PhoneBlackCreator : ProductCreater
    {
        public override IProduct CreaterProduct()
        {
            return new PhoneBlack();
        }
    }
}
