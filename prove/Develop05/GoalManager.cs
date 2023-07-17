using System.IO; 
public class GoalManager 
{
    private List<Goal> _goals= new List<Goal>
    {

    };

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
                    Console.WriteLine("The types of Goals are: ");
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
            i = i + 1;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Your goals are: ");
        Console.WriteLine();

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            Console.WriteLine();
            i = i + 1;
        }
    }
    public void CreateGoal(string goalType)
    {
        if (goalType == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal("", "", "");
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short discription of your goal? ");
            string discription = Console.ReadLine();
            Console.Write("How mny points are associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            _goals.Add(simpleGoal);
        }
        else if (goalType == "2")
        {
            EternalGoals eternalGoals = new EternalGoals("", "", "");
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short discription of your goal? ");
            string discription = Console.ReadLine();
            Console.Write("How mny points are associated with this goal? ");
            // int points = int.Parse(Console.ReadLine());
            _goals.Add(eternalGoals);
        }
        else if (goalType == "3")
        {
            ChecklistGoal checklistGoal = new ChecklistGoal("", "", "", 0, 0);
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short discription of your goal? ");
            string discription = Console.ReadLine();
            Console.Write("How mny points are associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Your goals are:");
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish? ");

        int goalNum = int.Parse(Console.ReadLine());

        if (_goals[goalNum].IsComplete())
        {
            Console.WriteLine("You have completed this goal already.");
        }
        else
        {
          _goals[goalNum].RecordEvent();
           Console.WriteLine($"Congratulations! You Have earned {_goals[goalNum].GetPoints()} points");
           // _score = _score + _goals[goalNum].
           
        }

    }

    public void SaveGoals()
    {
        Console.WriteLine("Name of file to save? ");
        string fileNameSave = Console.ReadLine();
        List<string> records = new List<string>();
        foreach (Goal goal in _goals)
        {
            string goalAsCSV = goal.GetStringRepresentation();
            records.Add(goalAsCSV);
        }
        File.WriteAllLines(fileNameSave, records);
    }
    public void LoadGoals()
    {
        // Console.WriteLine("Name of file to load? ");
        // string fileNameLoad = Console.ReadLine();
        // List<string> records = File.ReadAllLines(fileNameLoad).ToList();
        // foreach (string record in records)
        // {
        //     string[] splitString = record.Split("|");
        //     int i = 0;
        //     while (i == 0)
        //     {
        //         _score = int.Parse(splitString[0]);
        //         i = i + 1; 
        //     }
        //     if (splitString[0] == "SimpleGoal")
        //     {
        //         SimpleGoal simpleGoal = new SimpleGoal("", "", "");
        //         string name = splitString[1]; 
        //         string description = splitString[2];
        //         string points = splitString[3];
        //         _goals.Add(simpleGoal);
        //     }
        // }
        
    }
}