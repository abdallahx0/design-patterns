namespace StatePattern
{
    public class ShippedOrderState(OrderManagement orderManagement) : IOrderState
    {
        public void ProcessOrder()
            => Console.WriteLine("Cannot process the order at the current state");

        public void ShipOrder()
            => Console.WriteLine("The order is currently being shipped!");

        public void DeliverOrder()
        {
            Console.WriteLine("Delivering order now...");
            orderManagement.ChangeState(new DeliveredOrderState(orderManagement));
        }

        public void CancelOrder()
            => Console.WriteLine("Cannot cancel the order at the current state");
    }
}
