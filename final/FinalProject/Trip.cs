using System.Collections.Generic;

public class Trip
{
    private string _tripName;
    private Traveler _traveler;
    private Destination _destination;
    private Budget _budget;
    private List<TripItem> _items = new List<TripItem>();

    // This class puts one whole trip together
    public Trip(string tripName, Traveler traveler, Destination destination, Budget budget)
    {
        _tripName = tripName;
        _traveler = traveler;
        _destination = destination;
        _budget = budget;
    }

    public string GetTripName()
    {
        return _tripName;
    }

    public void AddItem(TripItem item)
    {
        _items.Add(item);
        _budget.AddExpense(item.CalculateCost());
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (TripItem item in _items)
        {
            total += item.CalculateCost();
        }

        return total;
    }

    public string GetTripDetails()
    {
        string details = $"Trip: {_tripName}\n";
        details += _traveler.GetDetails() + "\n";
        details += $"Destination: {_destination.GetFullName()}\n";
        details += _budget.GetBudgetDetails() + "\n";
        details += "Items:\n";

        foreach (TripItem item in _items)
        {
            details += "- " + item.GetStringRepresentation() + "\n";
        }

        return details;
    }

    public string GetTripSummary()
    {
        return $"{_tripName} to {_destination.GetFullName()} - Total Cost: ${GetTotalCost()}";
    }
}