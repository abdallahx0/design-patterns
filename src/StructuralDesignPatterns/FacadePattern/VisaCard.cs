namespace FacadePattern
{
    public class VisaCard : IPaymentMethod
    {
        public string GetType()
        {
            return "VisaCard";
        }
    }

}
