namespace StatePattern
{
    public class CancelledOrderState(OrderManagement orderManagement) : IOrderState
    {
        public void ProcessOrder()
            => Console.WriteLine("Cannot process the order at the current state...");

        public void ShipOrder()
            => Console.WriteLine("Cannot ship the order at the current state...");

        public void DeliverOrder()
            => Console.WriteLine("Cannot deliver the order at the current state...");

        public void CancelOrder()
            => Console.WriteLine("Order is already cancelled!");
    }
}
