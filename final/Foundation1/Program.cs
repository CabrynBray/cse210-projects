using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> VideosList = new List<Video>();

        Video V1 = new Video("Hello world", "Ethan Bray", 240);
        Comment V1C1 = new Comment("Anet Erasmus", "Good bye");
        Comment V1C2 = new Comment("Tyler Heaton", "Welcome to our planet");
        Comment V1C3 = new Comment("Sarah Taim", "Long time no see.");
        Comment V1C4 = new Comment("Quincy Rogers", "Nice to meet you");
        Comment V1C5 = new Comment("Ethan Bray", "Hello to you too");

        VideosList.Add(V1);
        V1.AddComment(V1C1);
        V1.AddComment(V1C2);
        V1.AddComment(V1C3);
        V1.AddComment(V1C4);
        V1.AddComment(V1C5);

        Video V2 = new Video("Top 5 things to do in SA", "Callum Niederberger", 190);
        Comment V2C1 = new Comment("Bradin Niederberger", "Let's goooooooo");
        Comment V2C2 = new Comment("Jarom Bray", "It's time for another visit");
        Comment V2C3 = new Comment("Daena Bray", "I miss you guys so much.");
        Comment V2C4 = new Comment("Kalya Alexander", "Number one is the best");
        Comment V2C5 = new Comment("Joanne Westfahl", "Why didnt you come see me?");

        VideosList.Add(V2);
        V2.AddComment(V2C1);
        V2.AddComment(V2C2);
        V2.AddComment(V2C3);
        V2.AddComment(V2C4);
        V2.AddComment(V2C5);

        Video V3 = new Video("How to play squash.", "Hayley Ward", 210);
        Comment V3C1 = new Comment("Nekitha Cronje", "You play so well");
        Comment V3C2 = new Comment("Bronwyn dos Santos", "I am learning alot from you");
        Comment V3C3 = new Comment("Timothy Engelbrecht", "Good Hayley!");
        Comment V3C4 = new Comment("Alex Palmer", "Thanks for the video");
        Comment V3C5 = new Comment("Suzel Zevenster", "Well done on last nights win.");

        VideosList.Add(V3);
        V3.AddComment(V3C1);
        V3.AddComment(V3C2);
        V3.AddComment(V3C3);
        V3.AddComment(V3C4);
        V3.AddComment(V3C5);

        Video V4 = new Video("The Divergent Series", "Theo James", 350);
        Comment V4C1 = new Comment("trice Prior", "Divergent");
        Comment V4C2 = new Comment("Four", "I am a good looking guy");
        Comment V4C3 = new Comment("Christina", "Insurgent");
        Comment V4C4 = new Comment("Peter", "Allegent");
        Comment V4C5 = new Comment("Caleb Prior", "Four");

        VideosList.Add(V4);
        V4.AddComment(V4C1);
        V4.AddComment(V4C2);
        V4.AddComment(V4C3);
        V4.AddComment(V4C4);
        V4.AddComment(V4C5);

        Console.WriteLine();
        foreach(Video video in VideosList) {
            video.DisplaySummary();
        }


    }
}