namespace FacadePattern
{
    public class CarRental
    {
        public void RentCar(string location, string startDateTime, string endDateTime)
        {
            Console.WriteLine("Renting car from: " + location + " with startDateTime: " + startDateTime + " and endDateTime: " + endDateTime);
        }
    }
}
