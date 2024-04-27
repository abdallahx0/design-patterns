namespace StrategyPattern.Strategies.Pricing
{
    internal class RegularPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal price)
        {
            return price;
        }
    }
}
