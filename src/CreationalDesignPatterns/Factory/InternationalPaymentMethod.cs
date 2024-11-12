namespace Factory
{
    public abstract class InternationalPaymentMethod : IPaymentMethod
    {
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiryDate { get; set; }

        protected InternationalPaymentMethod(string cardHolder, string cardNumber, string cvv, string expiryDate)
        {
            CardHolder = cardHolder;
            CardNumber = cardNumber;
            Cvv = cvv;
            ExpiryDate = expiryDate;
        }

        public abstract void AuthorizePayment();
        public abstract void StartMoneyTransfer();
        public abstract void CalculatePaymentFees(decimal amount);

    }
}
