namespace CommandPattern
{
    public class Door(string Name)
    {
        public void Lock()
        {
            Console.WriteLine("Locking door...");
        }

        public void Unlock()
        {
            Console.WriteLine("Unlocking door...");
        }
    }
}
