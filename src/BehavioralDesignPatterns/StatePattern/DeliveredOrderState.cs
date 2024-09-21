namespace StatePattern
{
    public class DeliveredOrderState(OrderManagement orderManagement) : IOrderState
    {
        public void ProcessOrder()
            => Console.WriteLine("Order cannot be processed because it's already delivered");

        public void ShipOrder()
            => Console.WriteLine("Order cannot be shipped because it's already delivered");

        public void DeliverOrder()
            => Console.WriteLine("Order is already delivered!");

        public void CancelOrder()
            => Console.WriteLine("Order cannot be cancelled because it's already delivered");
    }
}
