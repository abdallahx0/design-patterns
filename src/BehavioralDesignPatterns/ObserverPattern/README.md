# Newsletter System with Observer Pattern

This C# code implements a simple newsletter system using the Observer design pattern.

## Overview

The Observer pattern is a behavioral design pattern where an object (the subject) maintains a list of its dependents (observers) and notifies them of any state changes, usually by calling one of their methods. 
In this pattern, the subject doesn't need to know anything about its observers, only that they implement a certain interface.

## Code Explanation

### Interfaces

1. `ISubscriber`: This interface defines the contract for subscribers who are interested in receiving notifications from the publisher.

2. `IPublisher`: This interface defines the contract for publishers (subjects) who are responsible for managing subscribers and notifying them of any updates.

### Classes

1. `Newsletter`: This class implements the `IPublisher` interface and represents the publisher in our newsletter system. It maintains a list of subscribers and provides methods to subscribe, unsubscribe, and notify subscribers.

2. `User`: This class implements the `ISubscriber` interface and represents the subscribers of our newsletter system. Each user has a name and implements the `Notify` method to receive notifications.

### Main Functionality

1. **Subscribing and Unsubscribing**: Users can subscribe to the newsletter using the `Subscribe` method and unsubscribe using the `Unsubscribe` method of the `Newsletter` class.

2. **Notification**: The `SendNotification` method of the `Newsletter` class is used to send notifications to all subscribers by calling their `Notify` method.
