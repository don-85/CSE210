
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video { Title = "Exploring Uganda", Author = "Titus Muntu", LengthInSeconds = 300 };
        video1.AddComment(new Comment("Alice", "Amazing view!"));
        video1.AddComment(new Comment("Bob", "Love this place."));
        video1.AddComment(new Comment("Charlie", "Great edit!"));
        videos.Add(video1);

        Video video2 = new Video { Title = "C# Abstraction Tutorial", Author = "CodeWithTitus", LengthInSeconds = 450 };
        video2.AddComment(new Comment("Dave", "Very informative."));
        video2.AddComment(new Comment("Eva", "Thanks for this."));
        video2.AddComment(new Comment("Frank", "I learned a lot."));
        videos.Add(video2);

        Video video3 = new Video { Title = "My Travel Vlog", Author = "Titus Adventures", LengthInSeconds = 360 };
        video3.AddComment(new Comment("Grace", "Inspiring journey."));
        video3.AddComment(new Comment("Henry", "Where is this?"));
        video3.AddComment(new Comment("Ivy", "Loved the nature shots."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"	{comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
