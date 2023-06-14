using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        
        string Grade = "A";

        if (number >= 90)
        {
            Grade = "A";
        }
        else if (number >= 80)
        {
            Grade = "B";
        }
        else if (number >= 70)
        {
            Grade = "C";
        }
        else if (number >= 60)
        {
            Grade = "D";
        }
        else if (number < 60)
        {
            Grade = "F";
        }
        Console.WriteLine(Grade);

        if (number >= 70)
        {
            Console.WriteLine("Congrads you passed!");
        }
        else
        {
            Console.WriteLine("You failed, see you next year. ");
        }
    }
}