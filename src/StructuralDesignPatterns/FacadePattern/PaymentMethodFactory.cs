namespace FacadePattern
{
    public class PaymentMethodFactory
    {
        public IPaymentMethod CreatePaymentMethod(string paymentMethod)
        {
            if (paymentMethod.Equals(PaymentMethodOptions.VISA.ToString(), StringComparison.OrdinalIgnoreCase))
                return new VisaCard();

            if (paymentMethod.Equals(PaymentMethodOptions.MASTER_CARD.ToString(), StringComparison.OrdinalIgnoreCase))
                return new MasterCard();

            if (paymentMethod.Equals(PaymentMethodOptions.PAYPAL.ToString(), StringComparison.OrdinalIgnoreCase))
                return new Paypal();

            throw new NotImplementedException("Card type is not supported");
        }
    }

}
