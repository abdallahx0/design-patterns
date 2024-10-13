namespace FacadePattern
{
    public class Paypal : IPaymentMethod
    {
        public string GetType()
        {
            return "Paypal";
        }
    }

}
