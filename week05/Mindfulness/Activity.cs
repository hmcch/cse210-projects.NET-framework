using System;
using System.Threading;// Giving option to pause the console for the animations

public class Activity

{   // member variables private type

    private string _name;

    private string _description;

    private int _duration;


    // Constructor for the generation of basic information when 
    // there is a new activity that is selected

    public Activity(string name, string description)
    {

        _name = name;

        _description = description;


    }

    // To display the welcome message 
    // and ask user for the time duration of the current session    

    public void StartMessage()
    {
        Console.Clear();// First to clean the screen

        Console.WriteLine($"Welcome to the {_name}.");

        Console.WriteLine();

        Console.WriteLine(_description);

        Console.WriteLine();


        // Request from user the duration of the current session

        Console.Write("How long, in seconds, would you like for this current session? ");

        _duration = int.Parse(Console.ReadLine());// To convert from string into integer

        Console.WriteLine("\n Get Ready...");

        ShowSpinner(3);// Pause the execution a period of time of 3 s 
        // amd while a loading animation is displayed before begins the execution

    }

    // To display an ending message when a user ends with an activity

    public void EndMessage()
    {
        Console.WriteLine("\n Well done!!");

        ShowSpinner(3);// A little time so the user is able to think about the results

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");

        ShowSpinner(3);// A little time so the user is able to see time spent on this activity


    }

    // To give the child classes the access to read the private _duration

    protected int GetDuration()
    {

        return _duration;

    }

    //For the creation of a spinner animation to be executed

    protected void ShowSpinner(int seconds)
    {
        // This array it contains characters that 
        // will give form to the rotating stick animation

        string[] spin = { "|", "/", "-", "\\" };

        // Determine the time when the animation should stop

        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;// Index pointer for spin array

        // The loop will keep running until current time matches the estimation of ending time

        while (DateTime.Now < end)
        {
            Console.Write(spin[i]);// Prints current loading character

            Thread.Sleep(200);// Giving a pause to let the user check it

            Console.Write("\b \b");// Overwriting the last character

            // Cycle index (0-3) and wrap back to 0 using remainder operator
            i = (i + 1) % 4;
        }
    }

    // Creating a countdown

    protected void Countdown(int seconds)

    {
        // Loop backwards from starting seconds down to 1

        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);// Printing the current number

            Thread.Sleep(1000);// To make a pause of 1 second equivalent to 1000 ms

            Console.Write("\b \b");// To erase the number so the next one replaces it
        }
    }
}