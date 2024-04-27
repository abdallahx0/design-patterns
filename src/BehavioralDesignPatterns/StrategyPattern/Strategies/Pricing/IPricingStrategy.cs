namespace StrategyPattern.Strategies.Pricing
{
    internal interface IPricingStrategy
    {
        decimal CalculatePrice(decimal price);
    }
}
