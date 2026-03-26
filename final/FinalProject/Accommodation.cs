public class Accommodation : TripItem
{
    private string _accommodationName;
    private int _nights;
    private double _pricePerNight;

    // Stores hotel or place to stay
    public Accommodation(string name, string description, string accommodationName, int nights, double pricePerNight)
        : base(name, description, 0)
    {
        _accommodationName = accommodationName;
        _nights = nights;
        _pricePerNight = pricePerNight;
    }

    // Total cost depends on nights and price
    public override double CalculateCost()
    {
        return _nights * _pricePerNight;
    }

    public override string GetStringRepresentation()
    {
        return $"Accommodation: {_accommodationName}, Nights: {_nights}, Price/Night: ${_pricePerNight}, Total: ${CalculateCost()}";
    }
}