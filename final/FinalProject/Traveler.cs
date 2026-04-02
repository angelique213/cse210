// stores traveler info
public class Traveler
{
    private string _name;
    private string _email;

    public Traveler(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public string GetDetails()
    {
        return $"{_name} ({_email})";
    }
}