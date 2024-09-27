namespace CommandPattern.Command
{
    public class TurnLightOnCommand(Light light) : ICommand
    {
        public void Execute()
        {
            light.TurnOn();
        }
    }
}
