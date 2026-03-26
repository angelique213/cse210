using System;
using System.Collections.Generic;

public class TripManager
{
    private List<Trip> _trips = new List<Trip>();

    // Adds a trip to the list
    public void AddTrip(Trip trip)
    {
        _trips.Add(trip);
    }

    public void DisplayTrips()
    {
        if (_trips.Count == 0)
        {
            Console.WriteLine("No trips available.");
            return;
        }

        for (int i = 0; i < _trips.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_trips[i].GetTripSummary()}");
        }
    }

    public Trip FindTrip(string name)
    {
        foreach (Trip trip in _trips)
        {
            if (trip.GetTripName().ToLower() == name.ToLower())
            {
                return trip;
            }
        }

        return null;
    }

    public string GetSummary()
    {
        return $"Total trips: {_trips.Count}";
    }
}