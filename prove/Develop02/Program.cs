using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        ThoughtGenerator thoughtGenerator = new ThoughtGenerator();
        Journal journal = new Journal();
        int UserInputMenu = 0;
        List<string> menu = new List<String>
        {   
            "Please select one of the following choices:",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Spiritual Thought",
            "6. Quit",
            "what would you like to do?"
        };

        Console.WriteLine("Welcome to the Journal program.");

        while (UserInputMenu != 6)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            UserInputMenu = int.Parse(Console.ReadLine());

            switch (UserInputMenu)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write(">");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.Date.ToString("MMM dd, yyyy");

                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Name of file to load? ");
                    string fileNameLoad = Console.ReadLine();
                    journal.LoadFromFile(fileNameLoad);
                    break;
                case 4:
                    Console.WriteLine("Name of file to save? ");
                    string fileNameSave = Console.ReadLine();
                    journal.SaveToFile(fileNameSave);
                    break;
                case 5:
                    string thought = thoughtGenerator.GetRandomThought();
                    Console.WriteLine(thought);
                    break; 

            }
        }


    }
}