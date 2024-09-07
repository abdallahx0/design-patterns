# E-Commerce Platform

## Overview

This project is an **E-Commerce Platform** that allows customers to purchase products with varying pricing logic based on their membership type. There are three customer segments: **Regular**, **Gold**, and **Premium**. Once the product price is calculated, the system supports different payment methods, including **PayPal**, **VisaCard**, and **BankTransfer**, each with its own logic for processing payments and calculating fees.

To handle the flexible pricing and payment processing logic, we utilize the **Strategy Design Pattern**.

---

## Strategy Design Pattern

The **Strategy Pattern** is a behavioral design pattern that enables selecting an algorithm or operation at runtime from a family of algorithms. This pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. In this system, we apply the Strategy Pattern to manage both the pricing logic for different customer segments and the payment processing logic for different payment methods.

### How it works:

1. **Pricing Strategy**:
   - Defines different pricing algorithms for **Regular**, **Gold**, and **Premium** members.
   - Each customer segment has its own pricing logic, which can be dynamically chosen at runtime based on the customer's membership type.

2. **Payment Processing Strategy**:
   - Defines the payment processing algorithm for each payment method, such as **PayPal**, **VisaCard**, and **BankTransfer**.
   - Each payment method handles fees and processes the payment in its unique way, which can also be selected at runtime depending on the customer's choice during checkout.

By applying the Strategy Pattern to both pricing and payment, we separate the concerns of pricing logic and payment processing, making the system flexible and easy to extend.

---

## Example Usage of Strategy Design Pattern

### Pricing Strategy:
- The **PricingStrategy** interface defines the common contract for calculating product prices based on customer segments.
- **Concrete Pricing Strategies**: 
  - **RegularPricing**: Defines the default pricing logic.
  - **GoldPricing**: Offers a discount for gold members.
  - **PremiumPricing**: Offers a more significant discount for premium members.

### Payment Strategy:
- The **PaymentStrategy** interface defines the contract for processing payments.
- **Concrete Payment Strategies**:
  - **PayPalPayment**: Handles PayPal-specific payment logic and fee calculation.
  - **VisaCardPayment**: Processes payments via VisaCard with its own fee structure.
  - **BankTransferPayment**: Implements the logic for bank transfers, including any additional fees.

### Benefits:
- **Flexibility**: Both the pricing logic and payment processing can be changed dynamically at runtime, depending on the customer's segment or preferred payment method.
- **Extensibility**: New customer segments or payment methods can be easily added without modifying existing logic.
  
---

## Conclusion

By using the **Strategy Design Pattern**, the system gains flexibility and scalability when dealing with both **pricing strategies** for different customer segments and **payment strategies** for various payment methods. This approach allows for dynamic selection of the most appropriate algorithm at runtime, ensuring that the platform can easily adapt to future changes or additions in pricing models and payment methods.

