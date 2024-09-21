namespace StatePattern
{
    public class ProcessingOrderState(OrderManagement orderManagement) : IOrderState
    {
        public void ProcessOrder()
            => Console.WriteLine("The order is currently being processed!");

        public void ShipOrder()
        {
            Console.WriteLine("Shipping the order...");
            orderManagement.ChangeState(new ShippedOrderState(orderManagement));
        }

        public void DeliverOrder()
            => Console.WriteLine("The order cannot be delivered at the current state");

        public void CancelOrder()
        {
            Console.WriteLine("The order is being cancelled now...");
            orderManagement.ChangeState(new CancelledOrderState(orderManagement));
        }
    }
}
