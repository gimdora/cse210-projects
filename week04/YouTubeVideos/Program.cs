using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook Kimchi CChige", "Heewoong Kim", 480);
        video1.AddComment(new Comment("Juyeon", "This looks delicious!"));
        video1.AddComment(new Comment("Mitchell", "I tried this recipe and it worked great."));
        video1.AddComment(new Comment("Tommas", "Can you do a spicy version next time?"));
        videos.Add(video1);

        Video video2 = new Video("Intro to C# Classes", "Code Academy", 900);
        video2.AddComment(new Comment("Hank", "Very clear explanation, thanks!"));
        video2.AddComment(new Comment("Evan", "The examples really helped me understand."));
        video2.AddComment(new Comment("Fiona", "Please make a video about interfaces."));
        videos.Add(video2);

        Video video3 = new Video("Morning Exercise Routine", "HealthyLife", 600);
        video3.AddComment(new Comment("Kevin", "Perfect routine for the office."));
        video3.AddComment(new Comment("Harry", "I feel so much better after doing this."));
        video3.AddComment(new Comment("Diana", "Can you make a 10-minute version too?"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title:  {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetDisplayText()}");
            }

            Console.WriteLine();
        }
    }
}
