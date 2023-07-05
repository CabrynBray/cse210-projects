
class ReflectingActivity : Activity
{
    private List<string> prompt = new List<string>
    {
        "Think of when you did something really difficult",
        "Think of your dream life",
        "Think of what scares you",
        "Think about what makes you frustrated",
        "Think about someone you love",
        "Think about something you love doing"
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random random = new Random();

    public ReflectingActivity()
    {
        this.SetActivityName("Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when " +
            "you have shown strength and resilience. This will help you recognize the power you " +
            "have and how you can use it in other aspects of your life.");
    }
    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPromt();
        Console.WriteLine();

        Console.WriteLine("When you have soemthing in mind, press enter to continue.");
        string userInput = Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        int interval = GetDuration() / 3;
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine();
            DisplayQuestions();
            ShowCountDown(interval);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPromt()
    {
        int randomPromt = random.Next(0, prompt.Count());

        return prompt[randomPromt]; 
    }

    public string GetRandomQuestion()
    {
        int randomQuestion = random.Next(0, questions.Count());

        return questions[randomQuestion];
    }

    public void DisplayPromt()
    {
        Console.WriteLine($"---{GetRandomPromt()}---");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine($"> {GetRandomQuestion()} ");
    }
    
}