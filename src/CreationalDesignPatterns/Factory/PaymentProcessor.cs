namespace Factory
{
    public class PaymentProcessor(IPaymentMethodFactory paymentMethodFactory)
    {
        public void ProcessPayment(CardType cardType, decimal amount, string cardHolder, string cardNumber, string cvv, string expiryDate)
        {
            // Create the actual payment method instance and process payment
            var paymentMethod = paymentMethodFactory.CreatePaymentMethod(cardType, cardHolder, cardNumber, cvv, expiryDate);

            paymentMethod.AuthorizePayment();
            paymentMethod.StartMoneyTransfer();
            paymentMethod.CalculatePaymentFees(amount);
        }
    }
}
