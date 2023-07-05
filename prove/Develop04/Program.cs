using System;

class Program
{
    static void Main(string[] args)
    {

        int userMenuInput = 0;

        List<string> menu = new List<string>
        {
            "Menu Options:",
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listning activity",
            "4. Start Exercise activity",
            "5. Quit"
        };

        while (userMenuInput != 5)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenuInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case 4:
                    ExerciseActivity exerciseActivity = new ExerciseActivity();
                    exerciseActivity.Run();
                    break;

            }
        }
        Console.WriteLine("Hello Develop04 World!");
    }
}