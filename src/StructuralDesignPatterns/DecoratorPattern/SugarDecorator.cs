namespace DecoratorPattern
{
    public class SugarDecorator : CondimentDecorator, IBeverage
    {
        public SugarDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string Prepare()
        {
            return base.Prepare() + " with Suger";
        }
    }

}
