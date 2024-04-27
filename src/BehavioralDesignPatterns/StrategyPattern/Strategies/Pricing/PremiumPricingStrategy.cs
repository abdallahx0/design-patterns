namespace StrategyPattern.Strategies.Pricing
{
    internal class PremiumPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal price)
        {
            return price * 0.8m;
        }
    }
}
