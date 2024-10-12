namespace DecoratorPattern
{
    public class MilkDecorator : CondimentDecorator, IBeverage
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string Prepare()
        {
            return base.Prepare() + " with Milk";
        }
    }

}
