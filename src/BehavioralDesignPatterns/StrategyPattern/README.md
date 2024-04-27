## E-commerce Platform with Strategy Pattern
This project demonstrates the use of the Strategy Pattern to implement flexible pricing and payment logic in an e-commerce platform.

## Context
Different products may have varying pricing strategies based on factors like customer segment (regular, gold, premium).
At checkout, customers can choose from different payment methods like PayPal, VisaCard, and BankTransfer, each with its own processing logic and fees.

## Strategy Pattern Implementation
The Strategy Pattern allows us to define a family of algorithms (strategies) and encapsulate each one into a separate class. This enables switching between algorithms at runtime based on specific needs.

## 1. Pricing Strategies
An Interface IPricingStrategy defines the common interface for all pricing strategies.
Concrete pricing strategies like RegularPricingStrategy, GoldPricingStrategy, and PremiumPricingStrategy implement the IPricingStrategy interface, each with its own logic for calculating the final price based on customer segment and product details.

## 2. Payment Strategies
An Interface IPaymentStrategy defines the common interface for all payment methods.
Concrete payment strategies like PayPalPaymentStrategy, VisaCardPaymentStrategy, and BankTransferPaymentStrategy implement the IPaymentStrategy interface, each with its own logic for processing the payment and applying relevant fees.

## Advantages
Flexibility: Easily add new pricing strategies or payment methods without modifying existing code.
Maintainability: Each strategy is isolated, improving code readability and maintainability.
Open/Closed Principle: Open for extension (new strategies) but closed for modification (existing code).

## Project Structure (Example)
└── src
    ├── Enums
    |   ├── MembershipType.cs
    |   ├── PaymentMethod.cs
    ├── Strategies
    |    ├── Pricing
    |    |   ├── IPricingStrategy.cs
    |    |   ├── RegularPricingStrategy.cs
    |    |   ├── GoldPricingStrategy.cs
    |    |   └── PremiumPricingStrategy.cs
    |    └── Payment
    |        ├── IPaymentStrategy.cs
    |        ├── PayPalPaymentStrategy.cs
    |        ├── VisaCardPaymentStrategy.cs
    |        └── BankTransferPaymentStrategy.cs
    ├── Checkout.cs
    ├── Product.cs
    └── Program.cs

## Usage
## Product Pricing:
Based on the customer segment, select the appropriate PricingStrategy implementation.
Use the chosen strategy to calculate the final price for the product.

## Checkout Payment:
Based on the customer's selected payment method, select the appropriate PaymentStrategy implementation.
Use the chosen strategy to process the payment and apply any fees.