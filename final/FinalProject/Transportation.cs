public class Transportation : TripItem
{
    private string _type;
    private string _from;
    private string _to;

    // Stores travel between places
    public Transportation(string name, string description, double cost, string type, string from, string to)
        : base(name, description, cost)
    {
        _type = type;
        _from = from;
        _to = to;
    }

    public override double CalculateCost()
    {
        return _cost;
    }

    public override string GetStringRepresentation()
    {
        return $"Transportation: {_type} from {_from} to {_to}, Cost: ${CalculateCost()}";
    }
}