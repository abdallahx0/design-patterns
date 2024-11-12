namespace Factory
{
    public interface IPaymentMethodFactory
    {
        IPaymentMethod CreatePaymentMethod(CardType cardType, string cardHolder, string cardNumber, string cvv, string expiryDate);
    }
}
