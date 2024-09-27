namespace CommandPattern
{

    public class SmartHomeShortcut
    {
        private readonly Dictionary<string, ICommand> _commands;

        public SmartHomeShortcut()
        {
            _commands = new Dictionary<string, ICommand>();
        }

        public void SetCommand(string shortcutCommand, ICommand command)
        {
            _commands[shortcutCommand] = command;
        }

        public void OpenShortcut(string shortcutCommand)
        {
            if (_commands.TryGetValue(shortcutCommand, out var command))
            {
                command.Execute();
            }
        }
    }
}
