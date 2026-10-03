using System;
// To have access to use Lists
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // To create a main list to hold together all the video objects

        List<Video> videos = new List<Video>();

        // Data for Video1

        Video v1 = new Video("Learn the fundamentals of Programming", "Alejandro Montes", 500);

        // Instantiating Comment objects directly inside the method call

        v1.AddComment(new Comment("Frank", "Explanation could not be simpler!"));
        v1.AddComment(new Comment("Rose", "With this video I learned more than 1 month in college, thanks!!!!!"));
        v1.AddComment(new Comment("Mauricio", "Could you do a video about how to iterate through two lists at the same time?"));
        videos.Add(v1); // Push the comment to the list

        // Data for Video 2

        Video v2 = new Video("Laptop Review: Dell XPS 16", "PC Solutions", 600);
        v2.AddComment(new Comment("Mercedes", "The resolution of the display is beautiful!"));
        v2.AddComment(new Comment("Mario", "How long does the battery endures using the turbo mode (unplugged)?"));
        v2.AddComment(new Comment("Tania", "Will you have it on sale for this coming Black Friday??"));
        videos.Add(v2);

        // Data for Video 3

        Video v3 = new Video("How to improve self-confidence", "Sander Lane", 450);
        v3.AddComment(new Comment("Esmeralda", "You helped me so much with this video! I applied the steps of your video and I got the job!!!"));
        v3.AddComment(new Comment("Ivan", "Interesting, I will apply it and share the results below this comment"));
        v3.AddComment(new Comment("Francisca", "Yesterday was my first day as a kindergarten teacher and was so nervous but after watching this video I feel I can handle it!"));
        videos.Add(v3);

        // To iterate through each video inside the collection list
        // Outer loop

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            // Reaching inside the current video, 
            // fetching its comment list, 
            // prints each comment.
            // Inner loop

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($"- {c.Name}: {c.Text}");
            }

            // This line functions as a separator to avoid a look similar to a wall of text
            Console.WriteLine("______________________________________\n");

        } //Close the outer loop for the video
    }
}