using System;

public class Program
{
    public static void Main(string[] args)
    {
        // create manager to store all trips
        TripManager manager = new TripManager();

        bool running = true;

        // main menu loop
        while (running)
        {
            Console.WriteLine("\n===== Travel Planner =====");
            Console.WriteLine("1. Create a new trip");
            Console.WriteLine("2. Add item to a trip");
            Console.WriteLine("3. View all trips");
            Console.WriteLine("4. Find trip by name");
            Console.WriteLine("5. View trip summaries");
            Console.WriteLine("6. Delete a trip");
            Console.WriteLine("7. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateTrip(manager); // create a new trip
                    break;
                case "2":
                    AddItemToTrip(manager); // add activity/transport/etc
                    break;
                case "3":
                    manager.DisplayTrips(); // show all trips
                    break;
                case "4":
                    FindTrip(manager); // search for trip
                    break;
                case "5":
                    Console.WriteLine(manager.GetSummary()); // summary
                    break;
                case "6":
                    DeleteTrip(manager); // delete a trip
                    break;
                case "7":
                    running = false; // exit program
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // creates a new trip from user input
    private static void CreateTrip(TripManager manager)
    {
        Console.Write("Trip name: ");
        string tripName = Console.ReadLine();

        Console.Write("Traveler name: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("City: ");
        string city = Console.ReadLine();

        Console.Write("Country: ");
        string country = Console.ReadLine();

        double budgetAmount = ReadDouble("Budget: ");

        // create objects and link them together
        Traveler traveler = new Traveler(name, email);
        Destination destination = new Destination(city, country);
        Budget budget = new Budget(budgetAmount);

        Trip trip = new Trip(tripName, traveler, destination, budget);

        manager.AddTrip(trip);

        Console.WriteLine("Trip created.");
    }

    // lets user add items to a specific trip
    private static void AddItemToTrip(TripManager manager)
    {
        Console.Write("Enter trip name: ");
        string tripName = Console.ReadLine();

        Trip trip = manager.FindTripByName(tripName);

        if (trip == null)
        {
            Console.WriteLine("Trip not found.");
            return;
        }

        Console.WriteLine("1. Activity");
        Console.WriteLine("2. Transportation");
        Console.WriteLine("3. Accommodation");
        Console.Write("Choose item type: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            // create activity
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string desc = Console.ReadLine();

            double cost = ReadDouble("Cost: ");

            Console.Write("Location: ");
            string location = Console.ReadLine();

            Console.Write("Date: ");
            string date = Console.ReadLine();

            trip.AddItem(new Activity(name, desc, cost, location, date));
            Console.WriteLine("Activity added.");
        }
        else if (choice == "2")
        {
            // create transportation
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string desc = Console.ReadLine();

            double cost = ReadDouble("Cost: ");

            Console.Write("Type: ");
            string type = Console.ReadLine();

            Console.Write("From: ");
            string from = Console.ReadLine();

            Console.Write("To: ");
            string to = Console.ReadLine();

            trip.AddItem(new Transportation(name, desc, cost, type, from, to));
            Console.WriteLine("Transportation added.");
        }
        else if (choice == "3")
        {
            // create accommodation
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string desc = Console.ReadLine();

            Console.Write("Hotel: ");
            string hotel = Console.ReadLine();

            int nights = ReadInt("Nights: ");
            double price = ReadDouble("Price per night: ");

            trip.AddItem(new Accommodation(name, desc, hotel, nights, price));
            Console.WriteLine("Accommodation added.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    // search for trip and show details
    private static void FindTrip(TripManager manager)
    {
        Console.Write("Enter trip name: ");
        string name = Console.ReadLine();

        Trip trip = manager.FindTripByName(name);

        if (trip == null)
        {
            Console.WriteLine("Not found.");
        }
        else
        {
            Console.WriteLine(trip.GetTripDetails());
        }
    }

    // allows user to delete a trip
    private static void DeleteTrip(TripManager manager)
    {
        Console.Write("Enter trip name to delete: ");
        string name = Console.ReadLine();

        bool removed = manager.DeleteTrip(name);

        if (removed)
        {
            Console.WriteLine("Trip deleted.");
        }
        else
        {
            Console.WriteLine("Trip not found.");
        }
    }

    // helper method for safe double input
    private static double ReadDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
            {
                return value;
            }

            Console.WriteLine("Invalid number.");
        }
    }

    // helper method for safe int input
    private static int ReadInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value >= 0)
            {
                return value;
            }

            Console.WriteLine("Invalid number.");
        }
    }
}