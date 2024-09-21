namespace MediatorPattern
{
    public class ChatManagement : IChatMediator
    {
        private readonly Dictionary<string, List<User>> _groups;

        public ChatManagement()
        {
            _groups = new();
        }

        public void SendDirectMessage(string message, User toUser, User fromUser)
        {
            Console.WriteLine($"{fromUser.GetName()} is sending message: {message} to user: {toUser.GetName()}");
            toUser.ReceiveDirectMessage(message, fromUser);
        }

        public void SendGroupMessage(string message, User fromUser, string toGroup)
        {
            Console.WriteLine($"{fromUser.GetName()} is sending message: {message} to group: {toGroup}");
            if (_groups.TryGetValue(toGroup, out var users))
            {
                users.ForEach(user => user.ReceiveGroupMessage(message, fromUser, toGroup));
            }
        }

        public void RegisterUserToGroup(User user, string groupName)
        {
            if (!_groups.ContainsKey(groupName))
            {
                _groups[groupName] = new List<User> { user };
                return;
            }
            _groups[groupName].Add(user);
        }
    }

}
