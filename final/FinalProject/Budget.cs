public class Budget
{
    private double _maxBudget;
    private double _currentSpent;

    // Keeps track of trip budget
    public Budget(double maxBudget)
    {
        _maxBudget = maxBudget;
        _currentSpent = 0;
    }

    public void AddExpense(double amount)
    {
        _currentSpent += amount;
    }

    public double GetRemaining()
    {
        return _maxBudget - _currentSpent;
    }

    public bool IsOverBudget()
    {
        return _currentSpent > _maxBudget;
    }

    public string GetBudgetDetails()
    {
        return $"Budget: ${_maxBudget}, Spent: ${_currentSpent}, Remaining: ${GetRemaining()}";
    }
}