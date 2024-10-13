# Online Travel Booking System Example

## Overview

In this example, we are developing an online travel booking system that allows customers to plan their trips by **booking flights**, **reserving hotel rooms**, and **renting cars**. The system handles several interconnected subsystems, such as flight management, hotel reservations, car rentals, and payment processing. 

The challenge is to provide a simplified interface for customers to manage their bookings without needing to interact with each subsystem directly.

### Key Requirements

1. **Unified Booking Interface**: The system should provide a single interface that customers can use to book flights, reserve hotel rooms, and rent cars without needing to interact with each subsystem independently.
2. **Subsystem Management**: Internally, the system must interact with various subsystems to handle tasks like checking flight availability, processing hotel reservations, and managing payments.
3. **Easy System Interaction**: Users should be able to book their entire trip (flights, hotels, and cars) in one seamless experience, without needing to manage individual subsystems themselves.

### Example Scenario

For example, a customer planning a vacation may want to book a flight, reserve a hotel room, and rent a car for the trip. Instead of interacting with each of these services separately, the customer can use the booking system’s simplified interface, which handles all the necessary interactions with the flight, hotel, and car rental subsystems on their behalf.

## Design Pattern Used: Facade Pattern

### Facade Pattern Overview

The **Facade Pattern** is a structural design pattern that provides a simplified interface to a complex system of classes, libraries, or frameworks. It is particularly useful when:

- You have a complex system with multiple subsystems, and you want to simplify interactions with them.
- You need to provide a unified interface for clients to access the functionality of multiple subsystems.
- You want to reduce dependencies between clients and complex systems by introducing an intermediary.

In our online travel booking system example:

- **Facade**: The main booking interface that provides a simplified way for customers to book flights, hotels, and cars.
- **Subsystems**: The underlying systems, such as flight management, hotel reservation, car rental, and payment processing.

### Pattern Structure

1. **Facade (BookingSystem)**: Defines a unified interface that allows clients to access the core booking functionalities, including flights, hotels, cars, and payments.
2. **Subsystems (FlightService, HotelService, CarRentalService, PaymentService)**: Handle specific tasks for each type of booking, such as flight availability, hotel room reservation, and car rental processing. These are complex systems that the `BookingSystem` Facade interacts with.
3. **Client**: The customer who interacts with the `BookingSystem` facade to book a trip. The client does not need to know about the subsystems; the facade handles all interactions internally.

### Benefits

- **Simplified Interface**: The Facade Pattern provides a simplified interface that hides the complexities of multiple subsystems from the client.
- **Reduced Dependencies**: Clients interact with the facade rather than multiple subsystems directly, reducing coupling and making the code easier to maintain.
- **Improved Usability**: By abstracting away the complex internal workings of the system, the facade makes it easier for clients to interact with the system.

### Example Application

In this example, the `BookingSystem` Facade provides an interface for booking a complete trip. When a customer books a trip, the facade interacts with the `FlightService` to book flights, the `HotelService` to reserve rooms, the `CarRentalService` to rent cars, and the `PaymentService` to process payments. This unified interface allows the customer to handle all these tasks through a single entry point, simplifying the booking experience.

## Conclusion

The Facade Pattern is ideal for complex systems like an online travel booking system, where multiple interconnected subsystems need to be managed. This pattern provides a simplified interface for clients while managing the details of subsystem interactions, making it easier for customers to book their trips seamlessly.