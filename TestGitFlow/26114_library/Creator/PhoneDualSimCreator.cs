namespace _26114_library
{
    class PhoneDualSimCreator : ProductCreater
    {
       public override IProduct CreaterProduct()
        {
            return new PhoneDualSim();
        }
    }
}
