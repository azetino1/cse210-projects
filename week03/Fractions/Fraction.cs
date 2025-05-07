using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructors
    public Fraction() : this(1, 1) { }

    public Fraction(int numerator) : this(numerator, 1) { }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");
        
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and Setters
    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set
        {
            if (value == 0)
                throw new ArgumentException("Denominator cannot be zero.");
            _denominator = value;
        }
    }

    // Method to return fractional representation
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return decimal representation
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}