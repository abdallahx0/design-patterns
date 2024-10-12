namespace DecoratorPattern
{
    public class Tea : IBeverage
    {
        public string Prepare()
        {
            return "Tea with Tea Beans";
        }
    }
}
