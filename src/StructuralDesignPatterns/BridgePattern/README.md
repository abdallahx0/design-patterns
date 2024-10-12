# Streaming Video Platform Example

## Overview

In this example, we are building a simple video streaming platform that supports different video providers, such as **YouTube**, **Twitch**, and others. The platform offers a basic playback function with the ability to select video quality settings, like **HD** and **SD**.

### Key Requirements

1. **Multi-Provider Support**: The platform needs to support different video providers, each of which may have unique playback capabilities and video quality options.
2. **Quality Settings**: Users should be able to select the video quality (e.g., HD, SD). However, different providers may not support all quality levels (e.g., some might only support SD).

### Example Scenario

To illustrate, let’s say a user wants to stream a video from YouTube in HD. YouTube may support this, but if they switch to Twitch, the platform should handle whether HD is available or fallback to SD if needed. 

This platform needs to be extensible, so if additional video providers or quality levels are added later, it should be easy to integrate them without extensive code changes.

## Design Pattern Used: Bridge Pattern

### Bridge Pattern Overview

The **Bridge Pattern** is a structural design pattern that separates an abstraction from its implementation, allowing them to vary independently. This pattern is particularly useful when:

- You want to decouple an abstraction from its implementation so that the two can evolve independently.
- You need to manage multiple variants of an abstraction and its implementation.
- You want to avoid a "combinatorial explosion" of classes due to multiple dimensions of variation.

In our streaming video platform example:

- **Abstraction**: The playback functionality with the ability to set video quality.
- **Implementation**: The specific video providers (e.g., YouTube, Twitch) and their quality options.

By using the Bridge Pattern, we can easily extend the platform with new providers and quality settings without altering existing code.

### Pattern Structure

1. **Abstraction (IVideoPlayer)**: Defines the high-level interface for video playback and quality settings.
2. **Refined Abstraction**: Could be specific video player types or more specialized playback options.
3. **Implementor (IVideoProvider)**: Interface that defines methods for video providers.
4. **Concrete Implementors**: Specific video providers like YouTube and Twitch that implement the `IVideoProvider` interface.

### Benefits

- **Increased Flexibility**: The abstraction and implementation can be developed and modified independently.
- **Code Reusability**: Allows reusing code across different platforms and quality settings.
- **Extensibility**: New video providers and quality options can be added with minimal changes to existing code.

This example demonstrates how the Bridge Pattern enables us to create a flexible, extensible video streaming platform that accommodates multiple video providers and quality options without requiring extensive changes to the core platform code.

## Conclusion

The Bridge Pattern is ideal for this type of platform because it allows us to separate the concerns of video providers and quality settings. This approach not only reduces code duplication but also makes it easier to extend and maintain the platform as new features are added.

