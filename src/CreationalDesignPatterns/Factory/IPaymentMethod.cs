namespace Factory
{
    public interface IPaymentMethod
    {
        void AuthorizePayment();
        void StartMoneyTransfer();
        void CalculatePaymentFees(decimal amount);
    }
}
