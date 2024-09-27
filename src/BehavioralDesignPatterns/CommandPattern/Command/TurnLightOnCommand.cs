namespace CommandPattern.Command
{
    public class TurnLightOffCommand(Light light) : ICommand
    {
        public void Execute()
        {
            light.TurnOff();
        }
    }
}
