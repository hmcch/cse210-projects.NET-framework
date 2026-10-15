using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    //Polymorphism: This list stores generic "Goal" objects but because of inheritance
    //SimpleGoal, EternalGoal and CheckListGoal objects can be hold
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {

        bool running = true;

        //Main program loop: Keeps the game executing if the condition is false
        while (running)
        {
            Console.WriteLine("\nMenu Options:");

            Console.WriteLine("    1. Create New Goal");

            Console.WriteLine("    2. List Goals");

            Console.WriteLine("    3. Save Goals");

            Console.WriteLine("    4. Load Goals");

            Console.WriteLine("    5. Record Event");

            Console.WriteLine("    6. Display Player Info");

            Console.WriteLine("    7. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;

                case "2": ListGoalDetails(); break;

                case "3": SaveGoals(); break;

                case "4": LoadGoals(); break;

                case "5": RecordEvent(); break;

                case "6": DisplayPlayerInfo(); break;

                case "7": running = false; break;

                default: Console.WriteLine("Invalid option. Try again."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {

        Console.WriteLine($"Your current score: {_score}");

    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {

            Console.WriteLine("No goals created yet.");
            return;

        }

        int index = 1;
        foreach (Goal goal in _goals)
        {

            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;

        }
    }

    public void ListGoalDetails()
    {

        Console.WriteLine("\nThe goals up to this point are:");
        ListGoalNames();

    }

    public void CreateGoal()
    {

        Console.WriteLine("\nThe types of goals are:");

        Console.WriteLine("1. Simple Goal");

        Console.WriteLine("2. Eternal Goal");

        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("Enter a name for the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description for the goal: ");
        string desc = Console.ReadLine();

        Console.Write("What is the amount of points associated wih this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid type selected. Goal creation canceled.");
                return;
        }

        Console.WriteLine("Goal created correctly");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have zero goals to record progress on.");
            return;
        }

        Console.WriteLine("\nWhich goal did you accomplish?");
        ListGoalNames();

        int index = int.Parse(Console.ReadLine()) - 1;
        Goal goal = _goals[index];

        //Track completion status before and after recording the event

        bool wasCompleteBefore = goal.IsComplete();
        goal.RecordEvent();
        bool isCompleteNow = goal.IsComplete();
        if (!wasCompleteBefore)
        {
            _score += goal.GetPoints();

            //Checks if the generic "goal" is under the water a "ChecklistGoal"
            // If the answer is positive, by a period of time extracts it 
            // as the variable "checklist" so it lets call "GetBonus()"

            if (isCompleteNow && goal is ChecklistGoal checklist)
            {

                _score += checklist.GetBonus();

            }
        }

        Console.WriteLine($"Your score is now: {_score}");
    }

    public void SaveGoals()
    {
        Console.Write("Filename to save (e.g., mygoals.txt): ");
        string filename = Console.ReadLine();

        // In case the user type Enter without input anything provide a default name
        if (string.IsNullOrWhiteSpace(filename))
        {
            filename = "mygoals.txt";
        }

        try
        {
            string directoryPath = Path.GetDirectoryName(filename);

            if (!string.IsNullOrEmpty(directoryPath) && !Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            //File writing (output): With the keyword "using", the file stream closes by default when it's done
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);// Total saved score on line 1

                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());// Appending custom file string line for each object
                }
            }

            Console.WriteLine($"File of your Goals saved successfully to: {Path.GetFullPath(filename)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }



    public void LoadGoals()
    {
        Console.Write("Filename to load: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);//File reading (input): Pulls every line of text                                                 from the file straight into an array of strings.

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');// Parsing text: Splits every single line of text into tiny pieces each time a '|' character is found

            string type = parts[0];

            string name = parts[1];

            string desc = parts[2];

            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {

                bool complete = bool.Parse(parts[4]);

                var g = new SimpleGoal(name, desc, points);

                if (complete) g.RecordEvent();

                _goals.Add(g);

            }
            else if (type == "EternalGoal")
            {

                _goals.Add(new EternalGoal(name, desc, points));

            }
            else if (type == "ChecklistGoal")
            {

                int target = int.Parse(parts[4]);

                int bonus = int.Parse(parts[5]);

                int amount = int.Parse(parts[6]);

                var g = new ChecklistGoal(name, desc, points, target, bonus);

                for (int t = 0; t < amount; t++)
                    g.RecordEvent();

                _goals.Add(g);

            }
        }

        Console.WriteLine("Goals loaded!");

    }
}