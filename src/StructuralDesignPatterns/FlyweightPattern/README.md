# Game Development Example: Single Player and Enemies

## Overview

In this example, we are developing a game with a **single player** and multiple **enemies**, each of which has attributes like **health**, **weapon**, and **attack power**. The game has two types of enemies—**Weak** and **Strong**—each with unique health and attack power levels. Both the player and enemies can equip different weapons, which can provide extra attack power.

### Key Requirements

1. **Efficient Memory Usage**: Since there may be many enemies, we need to minimize memory usage by reusing common attributes, especially for frequently shared data like health and weapon attributes.
2. **Dynamic Weapon Assignment**: The player and enemies should be able to equip various weapons, some of which provide additional attack power.
3. **Flexible Attack Power Management**: Each enemy type (Weak, Strong) should have its own base attack power and health, and each weapon should modify the attack power as necessary.

### Example Scenario

For instance, the player may have a sword that increases attack power, while Weak and Strong enemies have their own health and attack power levels. Rather than creating separate objects for each enemy’s attributes, the game should share common attributes among similar types (e.g., the same weapon or health configuration for enemies of the same type), optimizing memory usage.

## Design Pattern Used: Flyweight Pattern

### Flyweight Pattern Overview

The **Flyweight Pattern** is a structural design pattern that allows efficient sharing of common attributes among a large number of similar objects. It is particularly useful when:

- You have a large number of similar objects, and you want to minimize memory usage.
- Certain attributes of the objects are shared (intrinsic) while others are unique (extrinsic).
- You need a mechanism to share intrinsic data across many objects without duplicating them.

In our game development example:

- **Flyweight**: Represents shared attributes among characters, such as base health, weapon type, and base attack power.
- **Context**: Represents extrinsic attributes like position and dynamic health values, which are specific to each individual instance.

### Pattern Structure

1. **Flyweight (CharacterType)**: Defines the shared, intrinsic properties, such as base health and base attack power.
2. **Concrete Flyweight (WeakEnemyType, StrongEnemyType, PlayerType)**: Represents specific character types that store intrinsic data, shared among multiple characters of the same type.
3. **Context**: Holds extrinsic data for each character, such as current health, position, and equipped weapon.
4. **Flyweight Factory**: Manages and provides access to Flyweight instances, ensuring that shared data is reused rather than duplicated.

### Benefits

- **Memory Efficiency**: The Flyweight Pattern reduces memory usage by sharing intrinsic data, which is particularly beneficial in scenarios with numerous similar objects.
- **Centralized Data Management**: Common attributes, like health and weapon data, are managed centrally, making it easier to update and maintain game configurations.
- **Scalability**: By sharing attributes among objects, the system can handle a large number of enemies without excessive memory consumption.

### Example Application

In this example, the Flyweight Pattern enables the game to manage both the player and enemies efficiently:

- The `Flyweight` represents shared attributes, such as health and attack power for Weak and Strong enemy types, as well as weapon effects.
- Each enemy instance (Weak or Strong) references the appropriate Flyweight for its type, reducing memory usage by sharing intrinsic attributes.
- The `Context` holds unique data, like each enemy’s current health and position, which varies per instance.

The Flyweight Factory ensures that only one instance of each enemy type (Weak, Strong) and weapon type is created, allowing all similar objects to share the same intrinsic data.

## Conclusion

The Flyweight Pattern is ideal for games with large numbers of similar entities, like enemies with shared characteristics, as it minimizes memory usage and simplifies management. By sharing common data and isolating unique attributes, the system can efficiently handle a high volume of game characters.