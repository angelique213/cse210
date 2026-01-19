using System; // I need this so I can use Console.WriteLine

public class Job
{
    public string _company;   // I store the company name here
    public string _jobTitle;  // I store the job title here
    public int _startYear;  // I store the start year here
    public int _endYear; // I store the end year here

    public void Display()    // I show one job in the required format
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        // This prints: JobTitle (Company) StartYear-EndYear
    }
}
