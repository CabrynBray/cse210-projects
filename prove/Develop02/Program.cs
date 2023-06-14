using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        int usersInput = -1;


        while (usersInput != 5)
        {
            Console.WriteLine("Please select one of the following Choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would yoou like to do? ");
            string num = Console.ReadLine();
            usersInput = usersInput = int.Parse(num);

            Journal journal1 = new Journal();

            if (usersInput == 1)
            {
                Console.WriteLine(">");
                string text = Console.ReadLine();
                
                journal1.AddEntry();

            }

            else if (usersInput == 2)
            {
                journal1.Display();
            }
            else if (usersInput == 3)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();

                journal1.LoadFromFile(file);

            }
            else if (usersInput == 4)
            {
                Console.Write("Please enter the file name: ");
                string file = Console.ReadLine();
                
                journal1.SaveToFile(file);
            }


        }

    }
}