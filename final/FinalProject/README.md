# Travel Planner

## Project Description
This is my final project for CSE 210. I created a Travel Planner program in C# because I enjoy traveling and wanted to make something useful and personal. The program helps users create trips, add activities, transportation, and accommodations, track their budget, and view trip details and summaries.

## Features
- Create a new trip
- Add activities
- Add transportation
- Add accommodations
- View all trips
- Find a trip by name
- View trip summaries
- Delete a trip

## Classes Used
This project uses the following classes:
- Program
- Trip
- TripManager
- Traveler
- Destination
- Budget
- TripItem
- Activity
- Transportation
- Accommodation

## OOP Principles
This project demonstrates:
- **Abstraction** through separate classes with clear responsibilities
- **Encapsulation** by keeping fields private
- **Inheritance** with TripItem as the base class
- **Polymorphism** through overridden methods like `CalculateCost()`

## How to Run
1. Open the project in Visual Studio or another C# IDE.
2. Build and run the program.
3. Use the menu to create trips and add trip items.

## Notes
- The program is console-based.
- The user enters trip information manually.
- Costs are calculated as items are added to each trip.