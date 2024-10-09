using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        // Creating instance of Fraction
        Fraction frac1 = new Fraction(); // 1/1
        Fraction frac2 = new Fraction(5); // 5/1
        Fraction frac3 = new Fraction(6, 7); // 6/7
        Fraction frac4 = new Fraction(3, 4); // 3/4
        Fraction frac5 = new Fraction(1, 3); // 1/3

        //Displaying the fractions and their decimal values
        Console.WriteLine(frac1.GetFractionString()); // output 1/1
        Console.WriteLine(frac1.GetDecimalValue()); //output 1.0

        Console.WriteLine(frac2.GetFractionString()); // output 5/1
        Console.WriteLine(frac2.GetDecimalValue()); //output 5.0

        Console.WriteLine(frac3.GetFractionString()); // output 6/7
        Console.WriteLine(frac3.GetDecimalValue()); //output 0.857142857

        Console.WriteLine(frac4.GetFractionString()); // output 3/4
        Console.WriteLine(frac4.GetDecimalValue()); //output 0.75

        Console.WriteLine(frac5.GetFractionString()); // output 1/3
        Console.WriteLine(frac5.GetDecimalValue()); //output 0.333333333
        }
}