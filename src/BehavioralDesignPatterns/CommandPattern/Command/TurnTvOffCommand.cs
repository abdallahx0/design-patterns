namespace CommandPattern.Command
{
    public class TurnTvOffCommand(Tv tv) : ICommand
    {
        public void Execute()
        {
            tv.TurnOff();
        }
    }
}
