namespace StrategyPattern.Strategies.Pricing
{
    internal class GoldPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal price)
        {
            return price * 0.9m;
        }
    }
}
