using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);
        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess =  guess = int.Parse(userGuess);

            if (guess == magicNum)
            {
                Console.WriteLine("YOU GUESSED IT!");
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
        }

    
    }
}