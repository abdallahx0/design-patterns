namespace Factory
{
    public class AmericanExpress : InternationalPaymentMethod
    {
        public AmericanExpress(string cardHolder, string cardNumber, string cvv, string expiryDate) : base(cardHolder, cardNumber, cvv, expiryDate)
        {
        }

        public override void AuthorizePayment()
        {
            Console.WriteLine("Authorizing American Express card...");
        }

        public override void StartMoneyTransfer()
        {
            Console.WriteLine("Starting money transfer for an American Express card...");
        }

        public override void CalculatePaymentFees(decimal amount)
        {
            Console.WriteLine("Calculating American Express card payment fees...");
        }
    }
}
