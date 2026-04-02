// represents hotel or stay
public class Accommodation : TripItem
{
    private string _hotel;
    private int _nights;
    private double _pricePerNight;

    public Accommodation(string name, string desc, string hotel, int nights, double price)
        : base(name, desc, 0)
    {
        _hotel = hotel;
        _nights = nights;
        _pricePerNight = price;
    }

    public override double CalculateCost()
    {
        return _nights * _pricePerNight; // total = nights * price
    }

    public override string ToString()
    {
        return $"Stay: {_hotel} for {_nights} nights (${CalculateCost()})";
    }
}