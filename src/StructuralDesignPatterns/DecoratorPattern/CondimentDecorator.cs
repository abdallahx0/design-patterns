namespace DecoratorPattern
{
    public class CondimentDecorator(IBeverage beverage) : IBeverage
    {
        public virtual string Prepare()
        {
            return beverage.Prepare();
        }
    }

}
