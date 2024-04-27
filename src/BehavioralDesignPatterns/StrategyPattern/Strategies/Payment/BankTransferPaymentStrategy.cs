namespace StrategyPattern.Strategies.Payment
{
    internal class BankTransferPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment of bank transfer...");
            Console.WriteLine($"Calculating fees of the amount {amount} for bank transfer...");
        }
    }
}
