# Text Editor

## Overview

This project is a **Text Editor** that provides core text editing functionality, along with an **Undo/Redo** mechanism. The **Undo** feature allows the user to restore the previous state of the text, while the **Redo** feature reverses the undo operation, restoring the text to a later state. To achieve this, we use the **Memento Design Pattern**, which is ideal for saving and restoring the state of objects without violating encapsulation.

---

## Memento Design Pattern

The **Memento Pattern** is a behavioral design pattern that allows saving and restoring the state of an object (in this case, the text document) without exposing its internal details. This pattern captures and externalizes an object's internal state so that the object can be restored to this state later. In our system, it is used to maintain the history of changes in the text and support **Undo/Redo** operations.

### How it works:

1. **Originator**: The object whose state needs to be saved and restored (i.e., the Text Editor). The originator creates a memento that holds its current state and uses the memento to restore that state later.
   
2. **Memento**: The object that stores the internal state of the originator. It allows capturing the text editor's state at a given time without exposing the internals of the originator.
   
3. **Caretaker**: Manages the history of mementos, storing them and using them to perform **Undo** and **Redo** operations. It saves the current state of the text document before changes are made and restores a previously saved state when needed.

Using this pattern allows for a robust and clean implementation of the undo/redo mechanism without tightly coupling the system’s components.

---

## Example Usage of Memento Pattern

### Key Components:
- **TextEditor (Originator)**: The text editor where users can type, delete, or modify text. It saves its state by creating mementos and restores previous states when undo/redo is triggered.
  
- **EditorMemento (Memento)**: Captures the internal state of the text editor at any point in time. This includes the text content and the cursor position, so it can be restored exactly as it was.

- **HistoryManager (Caretaker)**: Manages the list of saved mementos and supports the undo/redo operations. It keeps track of the past states in a stack for **undo** and stores redone states in another stack for **redo**.

### Benefits:
- **State Encapsulation**: The internal state of the Text Editor is not exposed outside, ensuring encapsulation.
- **Easy Undo/Redo**: The Memento Pattern makes it straightforward to implement **Undo/Redo** by managing different versions of the text's state.
- **Flexible Restoration**: The pattern can handle a variety of states, not just the text content, such as cursor position, formatting, or other properties in more advanced editors.

---

## Conclusion

By applying the **Memento Design Pattern**, we provide a robust mechanism for managing the **Undo/Redo** functionality in the text editor. This approach keeps the internal state of the editor encapsulated while allowing easy restoration of previous states. The system is well-structured, extensible, and ensures that the history of text changes is handled efficiently, providing users with the flexibility they expect from a modern text editor.

