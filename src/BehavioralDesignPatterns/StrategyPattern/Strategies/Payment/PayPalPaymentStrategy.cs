namespace StrategyPattern.Strategies.Payment
{
    internal class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment of paypal...");
            Console.WriteLine($"Calculating fees of the amount {amount} for paypal...");
        }
    }
}
