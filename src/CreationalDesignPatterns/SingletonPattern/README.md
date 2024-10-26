# Logger Class Example: Application Logging

## Overview

In this example, we are implementing a **Logger** class for an application that requires consistent logging across various components. The Logger provides methods for setting log levels and logging messages at different levels:

- **SetLogLevel**: Sets the logging level (e.g., Debug, Info, Warn, Error).
- **LogDebug**: Logs debug-level information, used for development and troubleshooting.
- **LogInfo**: Logs informational messages, providing insights into the application's flow.
- **LogWarn**: Logs warning messages, often indicating potential issues that do not halt the application.
- **LogError**: Logs error messages, capturing errors or exceptions that need attention.

### Key Requirements

1. **Single, Global Access Point**: Only one instance of the Logger should exist, accessible globally across the application to ensure consistent logging behavior.
2. **Centralized Log Level Configuration**: The log level should be configurable in one place to avoid inconsistency in log output.
3. **Thread Safety**: In multi-threaded environments, the Logger should prevent conflicts or duplication when logging messages.

### Example Scenario

For example, when the application starts, the Logger should initialize with a specific log level. Different components can then log messages based on this level, ensuring a consistent approach to logging throughout the application.

## Design Pattern Used: Singleton Pattern

### Singleton Pattern Overview

The **Singleton Pattern** is a creational design pattern that ensures only a single instance of a class exists throughout the application. It is particularly useful when:

- You need a single instance of a class to coordinate actions across the application.
- You want to control global access to a shared resource.
- You need to prevent the creation of multiple instances that could lead to inconsistencies.

In our Logger example:

- **Singleton**: Ensures that only one instance of the Logger class is created, providing centralized and consistent logging.
- **Global Access**: The single instance is accessible globally, allowing all parts of the application to access the same Logger.

### Pattern Structure

1. **Singleton (Logger)**: The Logger class is the single instance shared across the application. It provides methods for logging at different levels and a method to set the log level.
2. **Private Constructor**: The Logger’s constructor is private to prevent direct instantiation from other classes.
3. **Instance Retrieval Method**: A static method (often named `GetInstance`) provides access to the single Logger instance, creating it if it doesn't already exist.

### Benefits

- **Controlled Access**: Only one instance of the Logger exists, ensuring that all components log to the same destination with the same log level.
- **Consistent Configuration**: The log level and other settings are configured in one place, promoting consistency in log output.
- **Memory Efficiency**: The Singleton Pattern avoids unnecessary duplication by creating only one instance, which is especially useful for resource-intensive services like logging.

### Example Application

In this example, the Singleton Pattern helps us maintain a single, globally accessible Logger instance:

1. The Logger class has a private static field to hold the single instance.
2. The `GetInstance` method checks if an instance already exists; if not, it creates one, ensuring only one instance is ever created.
3. Methods like `LogDebug`, `LogInfo`, `LogWarn`, and `LogError` allow different types of messages to be logged, while `SetLogLevel` configures the log level for all messages.

By using the Singleton Pattern, the application ensures that logging is centralized, consistent, and efficient.

## Conclusion

The Singleton Pattern is ideal for services like logging, where a single, consistent access point is required. By restricting instantiation to one instance, it promotes controlled access, consistency, and efficient resource usage.
