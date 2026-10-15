//This class inherits from parent class "Goal" by keyword ":"
public class ChecklistGoal : Goal
{
    // Private variables restricting access to it
    private int _amountCompleted;// counter of number of times a user has completed an specific task until this moment
    private int _target;// required total number of times to achieve the goal
    private int _bonus;// Bonus points earned only if the target amount is reached

    // Constructor - To execute by default each time a new CheckList object is created
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)//The key word "base" passes name, description and points to the parent Goal constructor
    {

        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
        // Each checklist goal that is new begins the count at zero 0

    }

    public override void RecordEvent()
    // Override to change how the parent abstract RecordEvent method works for this class
    {
        _amountCompleted++;
        Console.WriteLine($"Progress recorded for '{_shortName}' (+{_points} points)");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Checklist complete! Bonus +{_bonus} points!");
        }
    }

    public override bool IsComplete()
    // Override parent IsComplete method so it can return a bool value
    {

        return _amountCompleted >= _target;

    }

    public int GetBonus()
    // Here a simple getter method to let other classes have the access to read the "_bonus" value
    {

        return _bonus;

    }

    public override string GetDetailsString()
    // Override to change how this specific goal displays on screen when listed in the menu.
    {
        //If IsComplete() is true, box becomes "[X]". If false, box becomes "[ ]"

        string box = IsComplete() ? "[X]" : "[ ]";

        // Returns readable sentence showing the checkbox, name, description and progress fraction.

        return $"{box} {_shortName} ({_description}) — Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()// Override to format data for text-file savings
    {

        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";// Using vertical bars "|" as separator for reading the text file with less obstacles.

    }
}