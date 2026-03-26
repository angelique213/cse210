using System;

class Program
{
    static void Main(string[] args)
    {
        TripManager manager = new TripManager();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nTravel Management System");
            Console.WriteLine("1. Create New Trip");
            Console.WriteLine("2. View Trips");
            Console.WriteLine("3. Find Trip");
            Console.WriteLine("4. Show Summary");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Ask the user for trip info
                Console.Write("Enter trip name: ");
                string tripName = Console.ReadLine();

                Console.Write("Enter traveler name: ");
                string travelerName = Console.ReadLine();

                Console.Write("Enter traveler email: ");
                string email = Console.ReadLine();

                Console.Write("Enter destination city: ");
                string city = Console.ReadLine();

                Console.Write("Enter destination country: ");
                string country = Console.ReadLine();

                Console.Write("Enter budget: ");
                double maxBudget = double.Parse(Console.ReadLine());

                // Create the main objects for the trip
                Traveler traveler = new Traveler(travelerName, email);
                Destination destination = new Destination(city, country);
                Budget budget = new Budget(maxBudget);

                Trip trip = new Trip(tripName, traveler, destination, budget);

                // Add a few sample items so cost still works
                trip.AddItem(new Activity("City Tour", "Guided tour", 40, city, "June 15"));
                trip.AddItem(new Transportation("Flight", "Round trip flight", 500, "Plane", "Home", city));
                trip.AddItem(new Accommodation("Hotel Stay", "3-night stay", "Main Hotel", 3, 120));

                manager.AddTrip(trip);

                Console.WriteLine("Trip created successfully.");
            }
            else if (choice == "2")
            {
                manager.DisplayTrips();
            }
            else if (choice == "3")
            {
                Console.Write("Enter trip name: ");
                string name = Console.ReadLine();

                Trip foundTrip = manager.FindTrip(name);

                if (foundTrip != null)
                {
                    Console.WriteLine(foundTrip.GetTripDetails());
                }
                else
                {
                    Console.WriteLine("Trip not found.");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine(manager.GetSummary());
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}