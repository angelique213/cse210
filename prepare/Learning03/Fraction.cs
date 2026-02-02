using System;

public class Fraction
{
    // stores the numerator
    private int _top;

    // stores the denominator
    private int _bottom;

    // creates a fraction with value 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // creates a fraction like wholeNumber/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // creates a fraction with given top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);
    }

    // sets the denominator and prevents zero
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            _bottom = 1;
        }
    }

    // sets the numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // returns the numerator
    public int GetTop()
    {
        return _top;
    }

    // returns the denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // returns the fraction as a string like 3/4
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
