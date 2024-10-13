using FacadePattern;

BookingTravelFacade bookingTravelFacade = new BookingTravelFacade();

Trip trip = new Trip();
trip.FlightDeparture = "Cairo";
trip.FlightDestination = "Spain";
trip.FlightDate = "2024-12-25 06:00 PM";
trip.RoomId = "456";
trip.CheckInDate = "2024-12-25 09:00 PM";
trip.CheckOutDate = "2024-12-28 09:00 PM";
trip.CarRentalLocation = "Spain airport";
trip.CarRentalStartDate = "2024-12-26 09:00 PM";
trip.CarRentalStartDate = "2024-12-28 08:00 PM";
trip.Amount = 2500;
trip.PaymentMethod = "VISA";

bookingTravelFacade.BookTrip(trip);

