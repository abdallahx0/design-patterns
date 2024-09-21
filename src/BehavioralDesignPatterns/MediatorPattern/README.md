# Chat Application

## Overview

This project is a **Chat Application** where multiple users can communicate with each other either directly (one-on-one) or in groups. Each user can **send** and **receive messages** from other users or from chat groups. To efficiently manage the communication between users without tight coupling, we use the **Mediator Design Pattern**.

---

## Mediator Design Pattern

The **Mediator Pattern** is a behavioral design pattern that allows objects (in this case, users) to communicate with each other through a mediator object. The mediator manages the communication and interaction between users, reducing direct dependencies between the users themselves. This pattern is useful in systems like chat applications where many participants need to interact in a decoupled way.

### How it works:

1. **Mediator (IChatMediator)**: The chat mediator acts as the mediator in the system. It facilitates the sending and receiving of messages between users. Users don’t communicate directly with each other but instead interact through the mediator (chat mediator).

2. **Colleague (User)**: Each user (participant in the chat) is a colleague that sends and receives messages through the mediator. The user doesn't need to know about other users or their details; they simply communicate via the chat mediator.

3. **Concrete Mediator (Concrete IChatMediator)**: The concrete chat mediator is responsible for managing and coordinating message passing. It knows all the users in the chat and routes messages to the appropriate recipients or groups.

---

## Example Usage of Mediator Pattern

### Key Components:
- **IChatMediator (Mediator Interface)**: Defines the methods that allow users to send and receive messages. The interface manages how messages are sent to specific users or broadcast to a group.

- **User (Colleague)**: Represents a user in the chat system. Each user can send messages and will receive messages through the mediator (chat mediator).

- **ConcreteChatMediator (Concrete Mediator)**: Implements the mediator interface and manages the logic for sending messages between users or broadcasting them to groups. It stores the list of participants and routes messages accordingly.

### Core Operations:
1. **sendMessage(sender, receiver, message)**: Allows a user to send a message to another user or group. The mediator ensures the message is properly delivered to the recipient(s).

2. **SendGroupMessage(sender, message)**: Sends a message from one user to all users in the chat mediator (for group chats).

3. **registerUser(user)**: Adds a new user to the chat mediator so they can participate in communications.

### Benefits:
- **Decoupling Users**: The mediator handles all communication between users, meaning users don’t need to know about each other’s details or implementation, reducing dependencies.

- **Easier Maintenance**: Since the mediator centralizes communication logic, it's easier to modify or extend message routing, logging, or other chat features without affecting individual users.

- **Scalability**: New users or groups can be added to the system without modifying existing users. The mediator can manage multiple communication types (private messages, group chats) in a scalable manner.

---

## Example Scenario

### Direct Communication:
- **User A** sends a message directly to **User B** using the mediator (chat mediator). The mediator routes the message from **User A** to **User B** without them knowing each other’s internal structure.

### Group Chat:
- **User C** sends a message to the entire group. The chat mediator mediator broadcasts the message to all users in the group.

### Key Functions:
- Users communicate **through** the chat mediator.
- The mediator is responsible for delivering messages to the correct recipients.
- Users can send either **direct messages** or **broadcast messages** to a group.

---

## Conclusion

The **Mediator Design Pattern** is an effective way to manage communication in the **Chat Application**, allowing multiple users to interact without being tightly coupled to one another. By introducing a mediator (the chat mediator), the system becomes more scalable, maintainable, and easy to extend. This design provides a clean separation of concerns and ensures that users communicate through the mediator for efficient message routing and handling.
