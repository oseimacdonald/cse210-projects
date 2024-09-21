using System;

class Program
{
    static void Main(string[] args)
    {
        // prompt for first name
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name?");
        string FirstName = Console.ReadLine();

        // prompt for last name
        Console.Write("What is your last name");
        string LastName = Console.ReadLine();

        // Output the formatted string
        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName} .");

    }
}