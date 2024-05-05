namespace ObserverPattern
{
    internal interface ISubscriber
    {
        void Notify(string message);
    }
}
