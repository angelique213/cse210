// stores destination info
public class Destination
{
    private string _city;
    private string _country;

    public Destination(string city, string country)
    {
        _city = city;
        _country = country;
    }

    public string GetFullName()
    {
        return $"{_city}, {_country}";
    }
}