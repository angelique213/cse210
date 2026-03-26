public class Activity : TripItem
{
    private string _location;
    private string _date;

    // Stores an activity for the trip
    public Activity(string name, string description, double cost, string location, string date)
        : base(name, description, cost)
    {
        _location = location;
        _date = date;
    }

    public override double CalculateCost()
    {
        return _cost;
    }

    public override string GetStringRepresentation()
    {
        return $"Activity: {_name}, {_description}, Location: {_location}, Date: {_date}, Cost: ${CalculateCost()}";
    }
}