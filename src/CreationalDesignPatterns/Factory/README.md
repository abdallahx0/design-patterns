# Payment Processor Example: E-commerce Application

## Overview

In this example, we are developing a **payment processor** for an **e-commerce application** that supports various payment methods, such as **Visa**, **MasterCard**, and **AmericanExpress**. Each payment type requires a consistent three-step process:

1. **Authorization**: Verifies payment details.
2. **Money Transfer**: Initiates the transfer of funds.
3. **Payment Fee Calculation**: Determines the transaction fee based on the payment method.

### Key Requirements

1. **Modular Payment Handling**: Each payment method (Visa, MasterCard, AmericanExpress) should have its own processing logic, encapsulated in a way that allows easy expansion for future payment types.
2. **Consistent Processing Flow**: All payment methods follow the same three-step process, but each can have unique implementations for each step.
3. **Scalable Architecture**: The design should support adding new payment methods without changing existing code, following the **Open/Closed Principle**.

### Example Scenario

For example, when a customer selects Visa as their payment method, the system should dynamically select the appropriate Visa payment processor, which will perform authorization, start the money transfer, and calculate fees according to Visa’s policies. The system should be able to do the same for other payment types (e.g., MasterCard, AmericanExpress).

## Design Patterns Used: Factory Method & Abstract Factory Pattern

### Factory Method Overview

The **Factory Method Pattern** is a creational design pattern that defines a method for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. It is used when:

- You want to delegate the instantiation of specific types to subclasses.
- You need to define a single interface for creating objects in a superclass, while the actual creation is handled by subclasses.

In our example:

- **Factory Method**: Creates a payment processor instance based on the selected payment method, allowing the main application to interact with a consistent interface regardless of the specific payment type.

### Abstract Factory Pattern Overview

The **Abstract Factory Pattern** is a creational pattern that provides an interface for creating related or dependent objects without specifying their exact classes. It is used when:

- You need to create families of related objects (e.g., different payment types) that follow a consistent interface.
- You want to encapsulate the creation logic of different types of objects, making it easy to switch between or add new families.

In our payment processor example:

- **Abstract Factory**: Provides an interface to create families of payment processors, allowing the application to generate specific processors (Visa, MasterCard, AmericanExpress) without knowing their concrete implementations.

### Pattern Structure

1. **Abstract Product (PaymentProcessor)**: Defines a general interface for payment processors with methods like `Authorize`, `StartMoneyTransfer`, and `CalculatePaymentFee`.
2. **Concrete Product (VisaProcessor, MasterCardProcessor, AmericanExpressProcessor)**: Implements payment processing logic specific to each payment type.
3. **Abstract Factory (PaymentProcessorFactory)**: Declares a method for creating a specific `PaymentProcessor` instance.
4. **Concrete Factory (VisaProcessorFactory, MasterCardProcessorFactory, AmericanExpressProcessorFactory)**: Implements the creation of the specific `PaymentProcessor` instance for each payment type.
5. **Client**: Uses the factory to create a `PaymentProcessor` and interacts with it through the `PaymentProcessor` interface without knowledge of the specific type.

### Benefits

- **Encapsulation of Creation Logic**: The Factory Method and Abstract Factory Pattern encapsulate payment processor creation logic, making it easier to manage and extend.
- **Open/Closed Principle**: New payment types can be added without modifying existing code, following SOLID principles.
- **Consistent Interface**: All payment processors implement the same interface, ensuring that each processor can be used interchangeably within the payment system.

### Example Application

In this example, the Factory Method and Abstract Factory Pattern simplify payment processing in the e-commerce application:

1. **PaymentProcessor** defines the standard processing methods: `Authorize`, `StartMoneyTransfer`, and `CalculatePaymentFee`.
2. Each `Concrete Processor` (e.g., `VisaProcessor`, `MasterCardProcessor`) implements these methods with logic specific to that payment type.
3. The application uses `PaymentProcessorFactory` to instantiate the required processor based on the selected payment method.

By leveraging these patterns, the application can support any number of payment types with a consistent interface and minimal impact on existing code.

## Conclusion

The Factory Method and Abstract Factory Patterns are ideal for building scalable, modular systems that require families of related objects. In this payment processor example, these patterns help organize payment processing logic, making it simple to add new payment methods while keeping code maintainable.