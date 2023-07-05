using System.Diagnostics;
class ListingActivity : Activity
{
    private int _count;
    List<string> prompts = new List<string>
    {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in " +
            "your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
      DisplayStartingMessage();

      Random random = new Random();

      Console.WriteLine("List as many responses as you can to the following prompt: ");
      // prompt
      string prompt = prompts[random.Next(prompts.Count)];
      Console.WriteLine($"---{prompt}---");
      Console.WriteLine();

      Console.Write("You may begin in: ");
      ShowCountDown(5);
      Console.WriteLine();

      Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        //int itemCount = 0;

        while (stopwatch.ElapsedMilliseconds / 1000 < this.GetDuration())
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            Console.WriteLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                _count++;
            }
        }

      // >
      // you listed number of items
      Console.WriteLine($"You listed {_count} items. ");


    
      DisplayEndingMessage();  
    }

    
}