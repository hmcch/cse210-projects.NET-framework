using System;
using System.Collections.Generic;// Import this to be able to use Lists so it can store the answers from the user

// The ListingActivity class inherits 
// from the "Activity" base class through the symbol ":"

public class ListingActivity : Activity
{
    //List of  the prompts topics 
    // for the user to get assigned

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // This constructor gives the function to assign 
    // the name and details for the activity

    public ListingActivity() :
        base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    // This method will handle the logic 
    // of asking a  certain topic 
    // and to store the answers from the user

    public void Run()
    {
        // To clear the console 
        // and ask for a timer
        StartMessage();

        Random rnd = new Random();
        Console.WriteLine("\nList as many responses as you can for the following prompt:");
        //Select a random prompt of the available list
        Console.WriteLine($"--- {_prompts[rnd.Next(_prompts.Count)]} ---");

        //Give user 5 s countdown to prepare their thoughts
        Console.Write("\nYou may begin in: ");

        Countdown(5);//Run base class countdown timer widget

        //Create an empty list to store items typed by user during program execution

        List<string> items = new List<string>();

        int duration = GetDuration();//Grab timer data input from parent class

        DateTime end = DateTime.Now.AddSeconds(duration);//Mark closing boundary time

        //Requesting and tracking text strings until current clock matches "end" mark

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            //Capture every input the user typed and store it inside the list
            items.Add(Console.ReadLine());
        }

        //Display total count of answers stored by the user typing

        Console.WriteLine($"\nYou listed {items.Count} items!");

        //Trigger closing sequence animation from base class

        EndMessage();
    }
}