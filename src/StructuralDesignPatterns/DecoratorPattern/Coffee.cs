namespace DecoratorPattern
{
    public class Coffee : IBeverage
    {
        public string Prepare()
        {
            return "Coffee with Coffee Beans";
        }
    }
}
