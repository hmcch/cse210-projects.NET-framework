using System;

// There is an issue trying to create a object directly from Goal, so the way to do it is to make objects of its child classes

public abstract class Goal
{

    //"protected" to keep variables private from outside access and at the same time to allow the child classes access to it
    protected string _shortName;

    protected string _description;

    protected int _points;

    public Goal(string name, string description, int points)// Constructor: To start the base data whenever a child class calls it using the ': base' keyword
    {
        // Saving passed arguments into protected variables

        _shortName = name;

        _description = description;

        _points = points;

    }

    // Using a Getter method. Because "_points" is protected/private, then other classes (i.e GoalManager) can access it without intermediaries.
    public int GetPoints()
    {

        return _points;

    }

    // With the use of abstract methods the only option is to force 
    // every single child class to create is own custom version 
    // of these methods by using the "override" keyword

    public abstract void RecordEvent();
    // To force child classes to define what happens when the user finishes or makes progress on this specific goal 

    public abstract bool IsComplete();
    // To force child classes to return a bool value checking if the goal is finished or not.

    public abstract string GetDetailsString();
    // To force child classes return a custom text string showing how it should look like a list.

    public abstract string GetStringRepresentation();
    // To force child classes to format its data into a custom text line for saving to a file.

}