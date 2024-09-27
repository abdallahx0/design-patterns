namespace CommandPattern
{
    public class SmartHomeMobileApplication
    {

        public void Execute(ICommand command)
        {
            command.Execute();
        }
    }
}
