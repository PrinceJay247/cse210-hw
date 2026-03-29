using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         Video video1 = new Video("How to Code in C#", "John Dev", 600);
        Video video2 = new Video("Encapsulation", "Jane Tech", 720);
        Video video3 = new Video("Learn Classes Fast", "CodeMaster", 540);

         video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Chris", "I learned a lot."));

         video2.AddComment(new Comment("Dave", "Nice explanation."));
        video2.AddComment(new Comment("Ella", "Clear and simple."));
        video2.AddComment(new Comment("Frank", "Loved it!"));

         video3.AddComment(new Comment("Prince", "Awesome content."));
        video3.AddComment(new Comment("Johnson", "Helped me understand classes."));
        video3.AddComment(new Comment("Patience", "Thanks a lot!"));

         List<Video> videos = new List<Video> { video1, video2, video3 };

         foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();  
        }
    }
}