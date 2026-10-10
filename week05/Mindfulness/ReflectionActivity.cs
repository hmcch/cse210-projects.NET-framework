using System;
using System.Collections.Generic;//Import this to be able to use Lists so it can store the text strings

// The ReflectionActivity class inherits 
// from the "Activity" base class through the symbol ":"

public class ReflectionActivity : Activity
{
    // To create a Private list of situational prompts 
    // so it can give the user different options to reflect about it

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // After displaying the prompt
    // create a Private list of follow-up 
    // questions related to the experience

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructor - Sets this activity name and brief description of it.
    // It passes up to the parent class constructor using "base()" keyword

    public ReflectionActivity() :
        base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. \n This will help you recognize the power you have and how you can use it in other aspects of your life.")
    { }

    // Core method to execute reflection routine step by step

    public void Run()
    {
        // Trigger greeting message and ask user for session duration in seconds

        StartMessage();

        // Create random generator object to select random items from lists

        Random rnd = new Random();
        Console.WriteLine("\nConsider the following prompt:");

        // Select and print random string from _prompts list using its count index

        Console.WriteLine($"--- {_prompts[rnd.Next(_prompts.Count)]} ---");

        // Pause execution and wait for user to press Enter before continue

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now reflect on these questions:");
        int duration = GetDuration();// Grab total running seconds specified by user
        DateTime end = DateTime.Now.AddSeconds(duration);// Calculate timestamp to stop loop

        // Loop keeps feeding reflection question until session time is over

        while (DateTime.Now < end)
        {
            // Select a random question from _questions list

            string q = _questions[rnd.Next(_questions.Count)];
            Console.Write($"> {q} ");

            // Pauses console for 5s with a spinning wheel animation to let user think

            ShowSpinner(5);

            // Blank line spacing before next question

            Console.WriteLine();
        }

        // Closing animation and final message from base class

        EndMessage();
    }
}