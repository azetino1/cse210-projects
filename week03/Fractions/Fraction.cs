using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction() : this(1, 1) { }

    public Fraction(int numerator) : this(numerator, 1) { }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");
        
        _top = numerator;
        _bottom = denominator;
    }

    // Getters and Setters
    public int Numerator
    {
        get { return _top; }
        set { _top = value; }
    }

    public int Denominator
    {
        get { return _bottom; }
        set
        {
            if (value == 0)
                throw new ArgumentException("Denominator cannot be zero.");
            _bottom = value;
        }
    }

    // Method to return fractional representation
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return decimal representation
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}