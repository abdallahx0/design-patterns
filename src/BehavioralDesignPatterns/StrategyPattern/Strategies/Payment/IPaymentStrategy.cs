namespace StrategyPattern.Strategies.Payment
{
    internal interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
