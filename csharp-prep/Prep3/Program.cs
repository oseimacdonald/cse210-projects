using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

                Random randomGenerator = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            // Step 3: Generate a random number between 1 and 100
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");

            // Step 2: Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                // Step 1: Ask for the user's guess
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();

                // Try to parse the user input
                if (int.TryParse(userInput, out guess))
                {
                    guessCount++;

                    // Check if the guess is higher, lower, or correct
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {guessCount} guesses.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }

        Console.WriteLine("Thanks for playing!");
    }

}