using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new()
        {
            new Video("How to Make Fresh Pasta", "Kitchen Notes", 525),
            new Video("A Walk Through the Redwoods", "Maya Chen", 742),
            new Video("Building a Simple Birdhouse", "Weekend Workshop", 618),
            new Video("Why the Moon Changes Shape", "Learn a Little", 391)
        };

        videos[0].AddComment(new Comment("Amira", "The dough texture tips worked perfectly."));
        videos[0].AddComment(new Comment("Jonah", "I tried this with whole wheat flour."));
        videos[0].AddComment(new Comment("Sofia", "The shaping step was easier than I expected."));

        videos[1].AddComment(new Comment("Drew", "The quiet forest sounds are wonderful."));
        videos[1].AddComment(new Comment("Nia", "I visited this trail last spring."));
        videos[1].AddComment(new Comment("Lucas", "The redwoods look incredible."));
        videos[1].AddComment(new Comment("Priya", "Adding this walk to my travel list."));

        videos[2].AddComment(new Comment("Mateo", "This is a great beginner project."));
        videos[2].AddComment(new Comment("Harper", "What size drill bit did you use?"));
        videos[2].AddComment(new Comment("Ethan", "I built one with my daughter this weekend."));

        videos[3].AddComment(new Comment("Lena", "The lamp explanation made it click."));
        videos[3].AddComment(new Comment("Omar", "I used to think Earth caused the phases."));
        videos[3].AddComment(new Comment("Grace", "Clear and easy to follow."));

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
