namespace CommandPattern.Command
{
    public class LockDoorCommand(Door door) : ICommand
    {
        public void Execute()
        {
            door.Lock();
        }
    }
}
