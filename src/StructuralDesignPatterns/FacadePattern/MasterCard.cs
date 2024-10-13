namespace FacadePattern
{
    public class MasterCard : IPaymentMethod
    {
        public string GetType()
        {
            return "MasterCard";
        }
    }

}
