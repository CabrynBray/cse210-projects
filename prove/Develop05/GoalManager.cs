public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int userMenuInput = 0;
        string goalType = "";
        List<string> menu = new List<string>
        {
            "Menu Options:",
            "1. Create new Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };
        while (userMenuInput != 6)
        {
            DisplayPlayerInfo();
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
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Which type of Goal do you want to create? ");
                    goalType = Console.ReadLine();
                    CreateGoal(goalType);
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine($"Your points: {_score}");
        Console.WriteLine("---------------------");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            Console.WriteLine();
            i++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Your goals are: ");
        Console.WriteLine();

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"  {i}. {goal.GetDetailsString()}");
            Console.WriteLine();
            i++;
        }
    }

    public void CreateGoal(string goalType)
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        Console.Write("How many points are associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                // Console.Write("Is the goal complete? (True/False) ");
                // string completed = "False"; 
                // bool isComplete = bool.Parse(completed);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points); // , isComplete);
                _goals.Add(simpleGoal);
                break;
            case "2":
                EternalGoals eternalGoals = new EternalGoals(name, description, points);
                _goals.Add(eternalGoals);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
               // int amountCompleted = 0;
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus); //, amountCompleted);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Your goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");

        int goalNum;
        if (!int.TryParse(Console.ReadLine(), out goalNum) || goalNum < 1 || goalNum > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        int goalIndex = goalNum - 1;
        Goal goal = _goals[goalIndex];

        if (goal.IsComplete())
        {
            Console.WriteLine("You have completed this goal already.");
        }
        else
        {
            goal.RecordEvent();
            int pointsEarned = goal.GetPoints();
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");
            _score += pointsEarned;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int i = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            if (i == 0)
            {
                _score = int.Parse(parts[0]);
                i++;
                continue;
            }

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal myGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                myGoal.RecordEvent();
                _goals.Add(myGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoals myGoal = new EternalGoals(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(myGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal myGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                myGoal.SetAmountCompleted(int.Parse(parts[4]));
                _goals.Add(myGoal);
            }
        }

        Console.WriteLine("File Loaded");
        // Console.Write("Name of file to load? ");
        // string fileNameLoad = Console.ReadLine();
        // List<string> records = File.ReadAllLines(fileNameLoad).ToList();

        // _goals.Clear();

        // foreach (string record in records)
        // {
        //     string[] splitString = record.Split("|");

        //     if (splitString.Length < 2)
        //     {
        //         Console.WriteLine("Invalid record format: " + record);
        //         continue;
        //     }

        //     string goalType = splitString[0];
        //     string name = splitString[1];
        //     string description = splitString[2];
        //     int points = int.Parse(splitString[3]);

        //     switch (goalType)
        //     {
        //         case "SimpleGoal":
        //             bool isComplete = bool.Parse(splitString[4]);
        //             SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
        //             _goals.Add(simpleGoal);
        //             break;
        //         case "EternalGoals":
        //             EternalGoals eternalGoals = new EternalGoals(name, description, points);
        //             _goals.Add(eternalGoals);
        //             break;
        //         case "ChecklistGoal":
        //             if (splitString.Length < 7)
        //             {
        //                 Console.WriteLine("Invalid record format: " + record);
        //                 continue;
        //             }
        //             int target = int.Parse(splitString[4]);
        //             int bonus = int.Parse(splitString[5]);
        //             int amountCompleted = int.Parse(splitString[6]);
        //             ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
        //             _goals.Add(checklistGoal);
        //             break;
        //         default:
        //             Console.WriteLine("Unknown goal type: " + goalType);
        //             break;
           // }
        // }
    }
}
