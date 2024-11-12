namespace Factory
{
    public class MasterCard : InternationalPaymentMethod
    {
        public MasterCard(string cardHolder, string cardNumber, string cvv, string expiryDate) : base(cardHolder, cardNumber, cvv, expiryDate)
        {
        }

        public override void AuthorizePayment()
        {
            Console.WriteLine("Authorizing master card...");
        }

        public override void StartMoneyTransfer()
        {
            Console.WriteLine("Starting money transfer for an master card...");
        }

        public override void CalculatePaymentFees(decimal amount)
        {
            Console.WriteLine("Calculating master card payment fees...");
        }
    }
}
