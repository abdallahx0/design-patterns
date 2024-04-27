using StrategyPattern.Strategies.Pricing;

namespace StrategyPattern
{
    internal class Product
    {
        private readonly IPricingStrategy _pricingStrategy;
        private readonly string _name;

        public Product(string name, IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
            _name = name;
        }

        public decimal CalculatePrice(decimal price)
        {
            return _pricingStrategy.CalculatePrice(price);
        }
    }
}
