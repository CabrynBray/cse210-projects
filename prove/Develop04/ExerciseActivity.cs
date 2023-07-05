
using System.Diagnostics;
class ExerciseActivity : Activity
{
    private string holdText = "Hold Hold Hold";

    public ExerciseActivity()
    {
        this.SetActivityName("Exercise Activity");
        this.SetDescription("This activity will help you exercise by walking you " +
            "through an exercise. " + 
            "Get your body moving when you exercise");
    }


    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("Get ready to do push-ups: ");
        ShowCountDown(5);

        int interval = GetDuration() / 6;
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Up....");
            foreach (char letter in holdText)
            {
                Console.Write(letter);
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine("Down....");
            foreach (char letter in holdText)
            {
                Console.Write(letter);
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }

}