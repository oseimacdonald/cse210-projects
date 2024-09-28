using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        // Step 1: Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        // Step 2: Determine the letter grade
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Step 3: Determine if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Your letter grade is: {letter}");
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine($"Your letter grade is: {letter}");
            Console.WriteLine("Don't worry, keep trying for next time!");
        }

        // Stretch Challenge 1: Adding '+' or '-' to the letter grade
        string sign = "";
        int lastDigit = gradePercentage % 10;

        if (letter == "A" && lastDigit >= 7)
        {
            sign = "+";
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }
        else if (letter == "B" && lastDigit >= 7)
        {
            sign = "+";
        }
        else if (letter == "B" && lastDigit < 3)
        {
            sign = "-";
        }
        else if (letter == "C" && lastDigit >= 7)
        {
            sign = "+";
        }
        else if (letter == "C" && lastDigit < 3)
        {
            sign = "-";
        }
        else if (letter == "D" && lastDigit >= 7)
        {
            sign = "+";
        }
        else if (letter == "D" && lastDigit < 3)
        {
            sign = "-";
        }
        // No F+ or F- grades
        // No A+ or A- grades, handled above

        // Display final letter grade with sign if applicable
        if (letter == "A" && sign == "-")
        {
            letter = "A-";
        }
        else if (letter == "A" && sign == "+")
        {
            letter = "A"; // No A+
        }
        else if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        Console.WriteLine($"Your final grade is: {letter}{sign}");
    }
}