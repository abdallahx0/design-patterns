namespace CommandPattern
{
    public class Tv(string Name)
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on TV...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off TV...");
        }
    }
}
