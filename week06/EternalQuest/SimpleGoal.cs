public class SimpleGoal : Goal
// This class inherits from "Goal" by using the ":" keyword
{
    private bool _isComplete;
    // Private boolean variable to keep track if the simple goal has been already accomplished or not

    // Constructor - This executes each time a new SimpleGoal object using  the "new" keyword is created.
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)// By using the keyword "base" passes name, description and points                                             to the parent Goal constructor
    {

        _isComplete = false;

    }

    public override void RecordEvent()
    // Override to change how the parent abstract RecordEvent method works for this specific class

    {

        Console.WriteLine($"Event recorded for '{_shortName}' (+{_points} points)");//Prints message through the console                                  by using string interpolation ($)

        _isComplete = true;
        // Because this is a simple goal (like "going to the sports activity of YSA"), doing it once flags its done

    }

    public override bool IsComplete()
    // Override parent IsComplete method so it can return a bool value.

    {

        return _isComplete;

    }

    public override string GetDetailsString()
    //Override to change how the goal 
    // is displayed on screen when 
    // listed as the menu

    {
        string box = _isComplete ? "[X]" : "[ ]";
        // If IsComplete() is true then the box turns to "[X]". Otherwise the box turns to "[ ]"

        return $"{box} {_shortName} ({_description})";
        // Returns readable sentence showing the checkbox, name and description
        // A format easily readable

    }

    public override string GetStringRepresentation()
    // Override to format data for text-file savings

    {

        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";//Use vertical bars "|" as separator for reading                         the text file with less difficulty

    }
}