namespace ObserverPattern
{
    internal class Newsletter : IPublisher
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers(string message)
        {
            _subscribers.ForEach(c => c.Notify(message));
        }

        public void SendNotification(string message)
        {
            NotifySubscribers(message);
        }
    }
}
