namespace MediatorPattern
{
    public class User(string name, IChatMediator chatMediator)
    {
        public void SendDirectMessage(string message, User toUser)
            => chatMediator.SendDirectMessage(message, toUser, this);

        public void ReceiveDirectMessage(string message, User user)
            => Console.WriteLine(name + " is receiving message: " + message + " from user: " + user.GetName());

        public void SendGroupMessage(string message, string groupName)
            => chatMediator.SendGroupMessage(message, this, groupName);

        public void ReceiveGroupMessage(string message, User fromUser, string groupName)
            => Console.WriteLine(name + " is receiving message: " + message + " from group: " + groupName + " and from user: " + fromUser.GetName());

        public string GetName()
            => name;
    }
}
