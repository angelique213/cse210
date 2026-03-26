public class Destination
{
    private string _city;
    private string _country;

    // Stores destination info
    public Destination(string city, string country)
    {
        _city = city;
        _country = country;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetFullName()
    {
        return $"{_city}, {_country}";
    }
}