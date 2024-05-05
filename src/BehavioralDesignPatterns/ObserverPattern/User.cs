namespace ObserverPattern
{
    internal class User : ISubscriber
    {
        private readonly string _name;

        public User(string name)
        {
            _name = name;
        }

        public void Notify(string message)
        {
            Console.WriteLine($"{_name} received a notification: {message}");
        }
    }
}
