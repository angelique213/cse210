// tracks money
public class Budget
{
    private double _max;
    private double _spent;

    public Budget(double max)
    {
        _max = max;
        _spent = 0;
    }

    public void AddExpense(double amount)
    {
        _spent += amount;
    }

    public double GetRemaining()
    {
        return _max - _spent;
    }
}