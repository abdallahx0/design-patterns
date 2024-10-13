namespace FacadePattern
{
    public class BookingTravelFacade
    {
        private readonly FlightManager flightManager;
        private readonly HotelReservation hotelReservation;
        private readonly CarRental carRental;
        private readonly PaymentProcessor paymentProcessor;
        private readonly PaymentMethodFactory paymentMethodFactory;

        public BookingTravelFacade()
        {
            flightManager = new FlightManager();
            hotelReservation = new HotelReservation();
            carRental = new CarRental();
            paymentProcessor = new PaymentProcessor();
            paymentMethodFactory = new PaymentMethodFactory();
        }

        public void BookTrip(Trip trip)
        {
            flightManager.BookFlight(trip.FlightDeparture, trip.FlightDestination, trip.FlightDate);
            hotelReservation.ReserveRoom(trip.RoomId, trip.CheckInDate, trip.CheckOutDate);
            carRental.RentCar(trip.CarRentalLocation, trip.CarRentalStartDate, trip.CarRentalEndDate);
            IPaymentMethod paymentMethod = paymentMethodFactory.CreatePaymentMethod(trip.PaymentMethod);
            paymentProcessor.ProcessPayment(trip.Amount, paymentMethod);
        }
    }
}
