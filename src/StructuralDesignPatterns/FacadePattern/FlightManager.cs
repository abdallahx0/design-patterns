namespace FacadePattern
{
    public class FlightManager
    {
        public void BookFlight(string departure, string destination, string date)
        {
            Console.WriteLine("Booking flight from: " + departure + " to: " + destination + " at date: " + date);
        }
    }
}
