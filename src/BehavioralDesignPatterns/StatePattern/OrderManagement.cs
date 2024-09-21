namespace StatePattern
{
    public class OrderManagement
    {
        private readonly Order _order;
        private IOrderState _orderState;

        public OrderManagement(Order order)
        {
            _order = order;
            _orderState = new NewOrderState(this);
        }

        public void ChangeState(IOrderState changedOrderState)
            => _orderState = changedOrderState;

        public void ProcessOrder()
            => _orderState.ProcessOrder();

        public void ShipOrder()
            => _orderState.ShipOrder();

        public void DeliverOrder()
            => _orderState.DeliverOrder();

        public void CancelOrder()
            => _orderState.CancelOrder();

        public Order GetOrder()
            => _order;
    }
}
