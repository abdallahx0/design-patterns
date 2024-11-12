namespace Factory
{
    public class InternationalPaymentMethodFactory : IPaymentMethodFactory
    {
        public IPaymentMethod CreatePaymentMethod(CardType cardType, string cardHolder, string cardNumber, string cvv, string expiryDate)
        {
            return cardType switch
            {
                CardType.VISA => new Visa(cardHolder, cardNumber, cvv, expiryDate),

                CardType.MASTER_CARD => new MasterCard(cardHolder, cardNumber, cvv, expiryDate),

                CardType.AMERICAN_EXPRESS => new AmericanExpress(cardHolder, cardNumber, cvv, expiryDate),

                _ => throw new ArgumentException("Card type is not supported...")
            };
        }
    }

}
