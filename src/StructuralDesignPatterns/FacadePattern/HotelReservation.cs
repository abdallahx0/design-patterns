namespace FacadePattern
{
    public class HotelReservation
    {
        public void ReserveRoom(string roomId, string checkInDate, string checkOutDate)
        {
            Console.WriteLine("Reserving the room: " + roomId + " with checkInDate: " + checkInDate + " and checkOutDate: " + checkOutDate);
        }
    }
}
