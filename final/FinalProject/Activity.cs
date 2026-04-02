// represents a trip activity (like visiting a place)
public class Activity : TripItem
{
    private string _location;
    private string _date;

    public Activity(string name, string desc, double cost, string location, string date)
        : base(name, desc, cost)
    {
        _location = location;
        _date = date;
    }

    public override double CalculateCost()
    {
        return GetCost(); // just returns cost
    }

    public override string ToString()
    {
        return $"Activity: {GetName()} at {_location} on {_date} (${CalculateCost()})";
    }
}