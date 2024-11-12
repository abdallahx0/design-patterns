namespace Factory
{
    public class Visa : InternationalPaymentMethod
    {
        public Visa(string cardHolder, string cardNumber, string cvv, string expiryDate) : base(cardHolder, cardNumber, cvv, expiryDate)
        {
        }

        public override void AuthorizePayment()
        {
            Console.WriteLine("Authorizing visa card...");
        }

        public override void StartMoneyTransfer()
        {
            Console.WriteLine("Starting money transfer for an visa card...");
        }

        public override void CalculatePaymentFees(decimal amount)
        {
            Console.WriteLine("Calculating visa card payment fees...");
        }
    }
}
