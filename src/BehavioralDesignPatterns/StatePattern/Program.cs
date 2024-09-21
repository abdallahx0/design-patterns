using StatePattern;

Order order = new Order();
order.Name = "Mobile";
order.Price = 500;

OrderManagement orderManagement = new OrderManagement(order);

orderManagement.ProcessOrder();
orderManagement.ShipOrder();
orderManagement.CancelOrder();
orderManagement.DeliverOrder();