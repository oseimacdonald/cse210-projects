using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load scriptures from a file into the library
            ScriptureLibrary scriptureLibrary = new ScriptureLibrary("scriptures.txt");
            Scripture scripture = scriptureLibrary.GetRandomScripture();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.Display());
                Console.WriteLine($"Memorized words: {scripture.GetMemorizedCount()}/{scripture.GetTotalWords()}");

                Console.WriteLine("Press Enter to hide words, type a word to memorize it, or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                // Check if the input is a word to memorize
                if (!string.IsNullOrWhiteSpace(input))
                {
                    scripture.MemorizeWord(input);
                }
                else
                {
                    scripture.HideRandomWords(1); // Hide a random word
                }
            }
        }
    }
}
