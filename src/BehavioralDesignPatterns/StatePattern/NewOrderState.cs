namespace StatePattern
{
    public class NewOrderState(OrderManagement orderManagement) : IOrderState
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Order: " + orderManagement.GetOrder().Name + " is being processing now...");
            orderManagement.ChangeState(new ProcessingOrderState(orderManagement));
        }

        public void ShipOrder()
            => Console.WriteLine("Cannot ship the order: " + orderManagement.GetOrder().Name + " at the current state...");

        public void DeliverOrder()
            => Console.WriteLine("Cannot deliver the order: " + orderManagement.GetOrder().Name + " at the current state...");

        public void CancelOrder()
        {
            Console.WriteLine("Cancelling order: " + orderManagement.GetOrder().Name);
            orderManagement.ChangeState(new CancelledOrderState(orderManagement));
        }
    }

}
