using System;

public class Fraction
{
    //private attributes
    private int _numerator;
    private int _denominator;

    // no-parameter constructor (defaults to 1/1)
    public Fraction()
    { 
        _numerator = 1;
        _denominator = 1;
    }

    // constructor with 1 parameter (eg., 5 -> 5/1)
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // consttructor with 2 parameters (eg., 6, 7 -> 6/7)
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator can not be zero.");
        }
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter and Setter for Numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    //Getter and Setter for Denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        if  (denominator == 0)
        {
            throw new ArgumentException("Denominator can not be zero.");
        }
        _denominator = denominator;
    }

    // Method to get the fraction as a string
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to get the decinal value
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}