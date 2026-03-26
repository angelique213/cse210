public class Traveler
{
    private string _name;
    private string _email;

    // Stores traveler info
    public Traveler(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string GetDetails()
    {
        return $"Traveler: {_name}, Email: {_email}";
    }
}