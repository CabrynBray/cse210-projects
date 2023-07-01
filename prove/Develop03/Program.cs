using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the scripture name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());
        Console.Write("Please enter the start verse: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Please enter the end verse (if non pleses enter 0): ");
        int end = int.Parse(Console.ReadLine());

        Console.Write("Please enter the vesre: ");
        string verse = Console.ReadLine();

            
        string userInput = "";

        Reference reference = new Reference(name, chapter, start, end);
        Scripture scripture = new Scripture(reference, verse);

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to finish");
            userInput = Console.ReadLine();

            scripture.HideRandomWords();
        }
        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("");
        Console.WriteLine("Thank you for playing");


    }
}