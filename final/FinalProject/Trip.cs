using System.Collections.Generic;

// represents one full trip
public class Trip
{
    private string _name;
    private Traveler _traveler;
    private Destination _destination;
    private Budget _budget;
    private List<TripItem> _items;

    public Trip(string name, Traveler traveler, Destination destination, Budget budget)
    {
        _name = name;
        _traveler = traveler;
        _destination = destination;
        _budget = budget;
        _items = new List<TripItem>();
    }

    public string GetTripName() => _name;

    // adds item and updates budget
    public void AddItem(TripItem item)
    {
        _items.Add(item);
        _budget.AddExpense(item.CalculateCost());
    }

    // shows full trip info
    public string GetTripDetails()
    {
        string result = $"Trip: {_name}\n";
        result += $"Traveler: {_traveler.GetDetails()}\n";
        result += $"Destination: {_destination.GetFullName()}\n";

        foreach (TripItem item in _items)
        {
            result += "- " + item.ToString() + "\n";
        }

        result += $"Remaining budget: ${_budget.GetRemaining()}\n";

        return result;
    }

    public string GetTripSummary()
    {
        return $"{_name} -> {_destination.GetFullName()}";
    }
}