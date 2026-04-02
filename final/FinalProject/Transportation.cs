// represents transport like flight or train
public class Transportation : TripItem
{
    private string _type;
    private string _from;
    private string _to;

    public Transportation(string name, string desc, double cost, string type, string from, string to)
        : base(name, desc, cost)
    {
        _type = type;
        _from = from;
        _to = to;
    }

    public override double CalculateCost()
    {
        return GetCost();
    }

    public override string ToString()
    {
        return $"Transport: {_type} from {_from} to {_to} (${CalculateCost()})";
    }
}