namespace CommandPattern.Command
{
    public class UnlockDoorCommand(Door door) : ICommand
    {
        public void Execute()
        {
            door.Unlock();
        }
    }
}
