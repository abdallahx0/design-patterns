namespace CommandPattern.Command
{
    public class TurnTvOnCommand(Tv tv) : ICommand
    {
        public void Execute()
        {
            tv.TurnOn();
        }
    }
}
