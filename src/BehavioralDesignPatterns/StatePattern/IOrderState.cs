namespace StatePattern
{
    public interface IOrderState
    {

        void ProcessOrder();
        void ShipOrder();
        void DeliverOrder();
        void CancelOrder();
    }
}
