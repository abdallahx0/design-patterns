namespace FacadePattern
{
    public class PaymentProcessor
    {
        public void ProcessPayment(decimal amount, IPaymentMethod paymentMethod)
        {
            Console.WriteLine("Processing the overall payment with amount: " + amount + " using: " + paymentMethod.GetType());
        }
    }
}
