# Smart Home Mobile Application

## Overview

This project is a **Smart Home Mobile Application** that allows users to control various smart home devices, such as turning lights on and off, locking and unlocking the front door, and turning the TV on and off. These actions can be triggered through the mobile app or via pre-configured shortcuts. 

To handle these device commands in a flexible and scalable way, we implement the **Command Design Pattern**.

---

## Command Design Pattern

The **Command Pattern** is a behavioral design pattern that turns a request (such as turning on a light) into a stand-alone object that contains all information about the request. This allows the system to parameterize methods, queue requests, and support operations like undo/redo. 

In the context of this smart home application, the command pattern helps decouple the invokers (e.g., mobile app buttons or shortcuts) from the objects that execute the actions (e.g., lights, door locks, TV).

### How it works:

1. **Command**: Defines an interface for executing operations (e.g., turn on/off, lock/unlock). Each command object encapsulates an action, making it easy to extend or modify system functionality.

2. **Concrete Commands**: These are implementations of the `Command` interface for specific devices, such as turning lights on/off, locking/unlocking the door, or turning the TV on/off. Each command knows about the device it needs to control.

3. **Invoker**: In this case, the invoker could be the **Mobile Application** or a **Shortcut**. It triggers the execution of commands without needing to know the specifics of how the devices work. 

4. **Receiver**: The devices (lights, door, TV) are the receivers. They perform the actual operations (e.g., switching the light on) when they receive a command.

---

## Example Usage of Command Pattern

### Key Components:
- **Command Interface**: Defines the common interface for all commands. Each command has an `Execute()` method to perform an action and, optionally, an `Undo()` method for reversing the action.

- **Concrete Commands**:
  - **TurnOnLightCommand**: Turns the light on.
  - **TurnOffLightCommand**: Turns the light off.
  - **LockDoorCommand**: Locks the front door.
  - **UnlockDoorCommand**: Unlocks the front door.
  - **TurnOnTVCommand**: Turns the TV on.
  - **TurnOffTVCommand**: Turns the TV off.

- **Invoker (Mobile App/Shortcuts)**: The mobile app acts as the invoker. It interacts with the command objects and triggers their `Execute()` method when the user presses a button or activates a shortcut. 

- **Receiver (Devices)**: These are the actual smart devices (lights, door lock, TV). They know how to perform the operations like turning on or off, locking or unlocking.

### Core Operations:
1. **Execute()**: Each concrete command knows how to execute its associated action (e.g., turning on a light or locking the door).

### Example Scenarios:
- **Turn on the light**: The user presses a button in the mobile app to execute the `TurnOnLightCommand`. The app sends the command to the light receiver, which turns the light on.

- **Lock the front door**: The app invokes the `LockDoorCommand`, which sends a request to the door to lock it.

- **Shortcut "Leave Home"**: A shortcut groups several commands, such as turning off all lights, locking the front door, and turning off the TV. The user can activate this shortcut with one tap in the mobile app.

### Benefits:
- **Decoupling of Invoker and Receiver**: The invoker (mobile app) doesn’t need to know how the devices (lights, door, TV) work. It simply sends commands, and the devices perform the actions.

- **Extensibility**: New devices or commands can be added without modifying the existing app structure. For instance, adding commands to control a thermostat or a security camera can be done easily.

- **Undo Feature**: By encapsulating actions in commands, we can provide undo functionality. Users can reverse operations like unlocking the door or turning off the lights.

- **Macro Commands (Shortcuts)**: The command pattern allows the app to group commands into macro commands, such as a "Goodnight Mode" that turns off all lights and locks the doors in one step.

---

## Conclusion

The **Command Design Pattern** provides a scalable and flexible approach to controlling smart devices through the **Smart Home Mobile Application**. By encapsulating device actions as command objects, the app decouples the user interface from the actual device logic, making it easier to extend, maintain, and add features like undo and shortcuts. This approach simplifies the control of multiple smart home devices while ensuring that the system remains easy to expand.
