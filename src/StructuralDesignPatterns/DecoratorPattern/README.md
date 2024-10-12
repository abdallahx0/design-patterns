# Beverage Ordering System Example

## Overview

In this example, we are developing a system for ordering beverages where customers can choose from various types of drinks, such as **coffee** and **tea**, and customize them with different condiments, like **milk**, **sugar**, and **whipped cream**. The challenge is to allow dynamic customization so that each beverage can be enhanced with multiple condiments in any combination desired by the customer.

### Key Requirements

1. **Beverage Variety**: The system needs to support different types of beverages (e.g., coffee, tea) with a base cost.
2. **Dynamic Customization**: Customers should be able to add one or more condiments to their beverage, and each condiment should add an additional cost. It should be easy to stack multiple condiments in any order.

### Example Scenario

For instance, a customer may order a **coffee with milk** or a **tea with lemon and sugar**. Another customer may decide to order a **coffee with milk and sugar**. The system needs to calculate the total cost for each beverage based on the base beverage type and the selected condiments.

## Design Pattern Used: Decorator Pattern

### Decorator Pattern Overview

The **Decorator Pattern** is a structural design pattern that allows you to dynamically attach additional behavior to objects. It is particularly useful when:

- You want to add responsibilities to objects without affecting other objects of the same class.
- You need to add or remove functionality from objects dynamically.
- You want to create a flexible structure that supports the combination of multiple behaviors.

In our beverage ordering system example:

- **Component**: Represents a general beverage, providing a method to get the description and cost.
- **Concrete Component**: Represents specific beverages (e.g., Coffee, Tea) with base costs.
- **Decorator**: Represents condiments, which add additional behavior (cost) to the beverages.
- **Concrete Decorators**: Represent specific condiments, such as Milk, Sugar, and Lemon, each adding its own cost to the beverage.

### Pattern Structure

1. **Component (Beverage)**: Defines the interface for all beverages, including methods to get the description and cost.
2. **Concrete Component (Coffee, Tea)**: Implements the `Beverage` interface with specific base costs for each type of beverage.
3. **Decorator (CondimentDecorator)**: An abstract class that also implements the `Beverage` interface and includes a reference to a `Beverage` object. It defines methods to get the description and cost, which will be overridden by concrete decorators.
4. **Concrete Decorators (Milk, Sugar, Lemon)**: Add specific condiments to beverages, modifying the description and cost accordingly.

### Benefits

- **Flexible Customization**: Customers can create any combination of beverage and condiments they desire, with the total cost calculated automatically.
- **Open for Extension, Closed for Modification**: New types of condiments or beverages can be added without modifying existing code, making the system highly extensible.
- **Easy to Maintain**: The Decorator Pattern allows for independent classes for each condiment, simplifying maintenance and testing.

### Example Application

Using the Decorator Pattern enables the system to handle dynamic beverage customization. For example, a **Coffee** can be decorated with **Milk** and **Sugar**, and a **Tea** can be decorated with **Lemon**. Each condiment wraps around the base beverage, adding its own cost and modifying the description. This flexible, stackable approach makes it easy to calculate the total cost of any customized order.

## Conclusion

The Decorator Pattern is well-suited for systems requiring dynamic, combinable behavior like beverage customization. By using this pattern, the system can flexibly handle various combinations of beverages and condiments, making it easy to expand with new options while keeping the codebase maintainable.
