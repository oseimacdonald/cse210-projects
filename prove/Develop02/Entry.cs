using System.Collections.Generic;

public class Entry

{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string Mood {get; set; } // new entry for mood
    public List<string> Tags { get; set; } = new List<string>(); // new prompt for tags

    public void Display()
    {
        Console.WriteLine($"{Date} [{Mood}]: {Prompt}\nResponse: {Response}");
        if (Tags.Count > 0)
        {
            Console.WriteLine("Tags: " + string.Join(",", Tags));
        }
    }
}
