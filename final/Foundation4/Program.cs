using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("2 March 2023", 30, 30.5);

        Cycling cycling = new Cycling("10 June 2023", 45, 3.5);

        Swimming swimming = new Swimming("26 June 2023", 15, 5);

        ActivityTracker activity = new ActivityTracker();
        activity.AddActivity(running);
        activity.AddActivity(cycling);
        activity.AddActivity(swimming);

        List<string> summeries = activity.GetDetailsSummary();
        foreach (string summary in summeries)
        {
            Console.WriteLine(summary);
        }
    }
}