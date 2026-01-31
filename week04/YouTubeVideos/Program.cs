

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "Code Academy", 600);
        video1.AddComment(new Comment("Ama", "Very helpful tutorial!"));
        video1.AddComment(new Comment("Kojo", "Clear and simple explanation."));
        video1.AddComment(new Comment("Yaw", "Loved this video."));

        Video video2 = new Video("Object-Oriented Programming Explained", "Tech World", 900);
        video2.AddComment(new Comment("Linda", "This finally makes sense."));
        video2.AddComment(new Comment("Mark", "Great examples."));
        video2.AddComment(new Comment("Sarah", "Well explained!"));

        Video video3 = new Video("Abstraction in C#", "Programming Hub", 750);
        video3.AddComment(new Comment("Daniel", "Perfect for beginners."));
        video3.AddComment(new Comment("Joy", "Thanks for this video."));
        video3.AddComment(new Comment("Chris", "Nice breakdown of concepts."));

        videos.Add(video1);
        videos.Add(video2);
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
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
