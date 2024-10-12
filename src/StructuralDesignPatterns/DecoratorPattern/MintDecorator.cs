namespace DecoratorPattern
{
    public class MintDecorator : CondimentDecorator, IBeverage
    {
        public MintDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string Prepare()
        {
            return base.Prepare() + " with Mint";
        }
    }

}
