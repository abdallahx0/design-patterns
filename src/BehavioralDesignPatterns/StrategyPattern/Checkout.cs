using StrategyPattern.Strategies.Payment;

namespace StrategyPattern
{
    internal class Checkout
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public Checkout(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
