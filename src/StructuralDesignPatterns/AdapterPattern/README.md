# Weather Application

## Overview

This project is a **Weather Application** that originally expects to receive weather information based on **city** and **country** in **XML format**. The goal is to extend the application to support a new input format: **longitude** and **latitude**, extract city and country from it, and show weather information in **JSON format**.

To accomplish this without changing the core functionality of the application or the third-party API, we use the **Adapter Design Pattern**.

---

## Adapter Design Pattern

The **Adapter Pattern** is a structural design pattern that allows objects with incompatible interfaces to work together. It acts as a bridge between the new system and the old one, adapting the interface of a class into another interface that clients expect.

In the context of this weather application, the adapter will transform the **longitude and latitude** input into **city and country**, and convert the weather data from **XML format** into **JSON format** without modifying the existing weather service.

### How it works:

1. **Client (Weather Application)**: The client (the existing weather application) only understands requests based on **city and country** and expects weather data in **XML format**.

2. **Adapter**: The adapter converts the new input of **longitude and latitude** into the format expected by the weather application, i.e., **city and country**. It also transforms the weather data from **XML** to **JSON** format to meet the new requirements.

3. **Adaptee (Third-Party Weather Service)**: The third-party weather service remains unchanged and continues to operate based on city and country inputs, providing weather data in XML format.

---

## Example Usage of Adapter Pattern

### Key Components:

- **Target Interface (WeatherService)**: Defines the interface that the application expects. In this case, it expects methods to retrieve weather data based on city and country in JSON format.

- **Adaptee (OldWeatherService)**: Represents the existing third-party weather service that retrieves weather data based on city and country in XML format. This service remains unchanged.

- **Adapter (LocationAdapter)**: Converts the new input of longitude and latitude to city and country using a geo-location service, calls the existing weather service (adaptee), and converts the XML response into JSON format.

### Core Operations:

1. **Adapt Input (Longitude/Latitude to City/Country)**: 
   - The adapter receives the **longitude** and **latitude**.
   - It uses a geo-location API to extract the **city** and **country**.
   
2. **Use Existing Weather Service**:
   - The adapter forwards the **city** and **country** to the existing weather service (adaptee), which fetches the weather data in **XML format**.

3. **Adapt Output (XML to JSON)**:
   - The adapter transforms the **XML** response from the weather service into **JSON** format before returning it to the client.

### Benefits:

- **Backward Compatibility**: The adapter ensures that the old weather service remains compatible with new input formats (longitude/latitude) without changing the existing implementation.
  
- **Format Conversion**: The weather data is converted from **XML** to **JSON**, making it suitable for modern applications that prefer JSON format for API responses.

- **Extensibility**: New input formats and output transformations can be added through additional adapters without modifying the core logic of the application.

---

## Example Scenario

### Input: 
- The new input format is **longitude** and **latitude**.

### Workflow:
1. The **mobile app** sends a request with **longitude** and **latitude** coordinates.
2. The **adapter** uses a geo-location service to convert the coordinates into **city** and **country**.
3. The **adapter** then sends the city and country to the existing **third-party weather service**, which returns weather data in **XML format**.
4. The **adapter** converts the **XML** data to **JSON format** and sends it back to the client.

### Example Flow:
- Input: Longitude = 34.0522, Latitude = -118.2437 (Los Angeles, USA).
- Adapter extracts city = "Los Angeles" and country = "USA".
- Adapter calls the third-party weather service, which returns weather data in XML format.
- Adapter converts the XML response into JSON format.
- Output: Weather data in JSON format for **Los Angeles, USA**.

### Code Example (Pseudocode):

1. **LocationAdapter**:
   - Accepts longitude and latitude.
   - Calls a geo-location service to get city and country.
   - Calls the existing weather service (adaptee) with city and country.
   - Converts XML response into JSON.

2. **OldWeatherService (Adaptee)**:
   - Fetches weather information based on city and country and returns it in XML format.

3. **WeatherApplication (Client)**:
   - Sends a request with longitude and latitude to the adapter.
   - Receives weather information in JSON format.

---

## Conclusion

The **Adapter Design Pattern** enables the **Weather Application** to handle new input types and output formats without modifying the existing weather service. It acts as a bridge between the old system that works with **city and country** and **XML**, and the new requirements involving **longitude and latitude** and **JSON**. This design pattern provides flexibility and backward compatibility, making it easier to extend the system with new features.
