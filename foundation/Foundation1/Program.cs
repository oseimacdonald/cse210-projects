using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("Learning C#", "Alice", 300);
        Video video2 = new Video("Introduction to OOP", "Bob", 450);
        Video video3 = new Video("C# Design Patterns", "Charlie", 600);

        // Create comment objects
        Comment comment1 = new Comment("Dave", "Great video!");
        Comment comment2 = new Comment("Eva", "Very informative, thanks!");
        Comment comment3 = new Comment("Frank", "I learned a lot from this.");
        Comment comment4 = new Comment("Grace", "Can't wait for the next one!");

        // Add comments to videos
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video2.AddComment(comment3);
        video3.AddComment(comment4);
        video3.AddComment(comment1);
        video3.AddComment(comment2);

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details for each video
        foreach (var video in videos)
        {
            Console.WriteLine(video.GetDetails());
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommentDetails());
            }
            Console.WriteLine(); // Blank line for separation
        }
    }
}
