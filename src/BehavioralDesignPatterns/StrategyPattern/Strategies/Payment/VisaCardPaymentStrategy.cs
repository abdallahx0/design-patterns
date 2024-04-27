namespace StrategyPattern.Strategies.Payment
{
    internal class VisaCardPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment of visa cards...");
            Console.WriteLine($"Calculating fees of the amount {amount} for visa cards...");
        }
    }
}
