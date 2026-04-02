using System.Collections.Generic;

// manages multiple trips
public class TripManager
{
    private List<Trip> _trips = new List<Trip>();

    public void AddTrip(Trip trip)
    {
        _trips.Add(trip);
    }

    public void DisplayTrips()
    {
        if (_trips.Count == 0)
        {
            System.Console.WriteLine("No trips found.");
            return;
        }

        foreach (Trip trip in _trips)
        {
            System.Console.WriteLine(trip.GetTripDetails());
        }
    }

    public Trip FindTripByName(string name)
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

    // removes a trip by name
    public bool DeleteTrip(string name)
    {
        for (int i = 0; i < _trips.Count; i++)
        {
            if (_trips[i].GetTripName().ToLower() == name.ToLower())
            {
                _trips.RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    public string GetSummary()
    {
        if (_trips.Count == 0)
        {
            return "No trips available.";
        }

        string result = "";

        foreach (Trip trip in _trips)
        {
            result += trip.GetTripSummary() + "\n";
        }

        return result;
    }
}