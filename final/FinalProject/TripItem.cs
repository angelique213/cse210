public class TripItem
{
    protected string _name;
    protected string _description;
    protected double _cost;

    // Base constructor for all trip items
    public TripItem(string name, string description, double cost)
    {
        _name = name;
        _description = description;
        _cost = cost;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    // This can be overridden in child classes
    public virtual double CalculateCost()
    {
        return _cost;
    }

    // Returns a basic string for the item
    public virtual string GetStringRepresentation()
    {
        return $"{_name} - {_description} - ${CalculateCost()}";
    }
}