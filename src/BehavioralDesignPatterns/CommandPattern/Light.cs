namespace CommandPattern
{
    public class Light(string Name)
    {
        public string Name { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("Turning on light....");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off light....");
        }
    }
}
