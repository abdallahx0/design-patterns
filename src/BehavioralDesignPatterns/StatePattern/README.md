# E-Commerce Order Management System

## Overview

This project is an **E-Commerce Order Management System** designed to handle orders as they progress through various stages, such as **New**, **Processing**, **Shipped**, and **Delivered**. The system's behavior changes based on the **current state** of the order. For example, a "New" order can be processed and canceled, while a "Shipped" order cannot be canceled but can be marked as delivered.

To handle these dynamic behaviors, we use the **State Design Pattern**.

---

## State Design Pattern

The **State Pattern** is a behavioral design pattern that allows an object to alter its behavior when its internal state changes. The object will appear to change its class. In this system, an **Order** can change its behavior (e.g., what operations it allows) depending on its **state** (e.g., New, Processing, Shipped, Delivered).

### How it works:

1. **Context (Order)**: The order acts as the context object. It holds a reference to the current state and delegates state-specific behavior (e.g., processing, shipping, canceling) to the state object.

2. **State (Order State)**: Defines the common interface for all states. Each state (e.g., New, Processing, Shipped) implements specific behaviors that are allowed in that state, such as marking the order as shipped or delivered, or canceling the order.

3. **Concrete States**:
   - **New Order State**: The order is new and can be processed or canceled.
   - **Processing State**: The order is being processed and can either be canceled or marked as shipped.
   - **Shipped State**: The order has been shipped and cannot be canceled but can be marked as delivered.
   - **Delivered State**: The order has been delivered and no further actions can be taken.

By using the State Pattern, the system ensures that each state handles its own behavior, keeping the context (order) clean and easy to manage.

---

## Example Usage of State Pattern

### Key Components:
- **Order (Context)**: Represents the order in the system. It maintains a reference to the current state and delegates operations (like canceling or shipping) to the state object.
  
- **OrderState (State Interface)**: Defines the methods that each state should implement, such as `ProcessOrder()`, `ShipOrder()`, `DeliverOrder()`, and `CancelOrder()`.

- **NewOrderState (Concrete State)**: Handles behavior for a new order. It allows the order to be processed or canceled.

- **ProcessingOrderState (Concrete State)**: Represents an order that is currently being processed. It allows the order to be canceled or shipped.

- **ShippedOrderState (Concrete State)**: Represents an order that has been shipped. This state disallows cancellation but allows the order to be marked as delivered.

- **DeliveredOrderState (Concrete State)**: Represents an order that has been delivered. No further actions are allowed in this state.

### Core Operations:
1. **ProcessOrder()**: Transitions the order from **New** to **Processing**.
   
2. **ShipOrder()**: Transitions the order from **Processing** to **Shipped**.

3. **DeliverOrder()**: Marks a **Shipped** order as **Delivered**.

4. **CancelOrder()**: Cancels the order if it's in the **New** or **Processing** state. Orders in **Shipped** or **Delivered** states cannot be canceled.

5. **State Transitions**: Each state dictates the possible transitions to the next state (e.g., a **New** order can transition to **Processing**, but a **Shipped** order cannot return to **New**).

### Benefits:
- **Encapsulation of State-Specific Behavior**: Each state encapsulates its own logic, preventing state-related logic from cluttering the main order class.
  
- **Simplified Context (Order)**: The `Order` class does not need to handle all possible state behaviors directly. It delegates these behaviors to the appropriate state.

- **Scalability**: New states (e.g., "Returned", "Refunded") can be added without modifying the existing state transition logic.

- **Consistency**: Ensures that the order behaves appropriately according to its current state, preventing invalid operations like canceling a shipped order.

---

## Conclusion

The **State Design Pattern** allows the **E-Commerce Order Management System** to dynamically adjust its behavior based on the current state of an order (e.g., New, Processing, Shipped, Delivered). Each state encapsulates the actions allowed for that particular stage, simplifying the overall system while ensuring that state-specific rules are followed. This approach also makes the system **extensible** and **easy to maintain**, as new states can be introduced without modifying the core logic.
