// base class for anything in the trip (activity, transport, etc.)
public abstract class TripItem
{
    private string _name;
    private string _description;
    private double _cost;

    public TripItem(string name, string description, double cost)
    {
        _name = name;
        _description = description;
        _cost = cost;
    }

    public string GetName() => _name;
    public string GetDescription() => _description;
    public double GetCost() => _cost;

    // default details
    public virtual string GetDetails()
    {
        return $"{_name} - {_description}";
    }

    // each child class will calculate differently
    public abstract double CalculateCost();
}