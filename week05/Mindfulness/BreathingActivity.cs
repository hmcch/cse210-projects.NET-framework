using System;

// The BreathingActivity class inherits 
// from the "Activity" base class through the symbol ":"

public class BreathingActivity : Activity
{
    // This constructor passes the values 
    // to the parent constructor by using "base()"

    public BreathingActivity() :
        base("Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly.                  \nClear your mind and focus on your breathing.")
    { }

    // This is the Main method to run the breathing routine

    public void Run()
    {

        // To call the welcome message 
        // and get the duration of
        // the session directly from the base class

        StartMessage();

        // How long the activity should run 
        // based on user input in seconds

        int duration = GetDuration();

        // To create a timestamp
        // to determine the moment 
        // the session should stop

        DateTime end = DateTime.Now.AddSeconds(duration);

        // The loop keeps executing
        // the breathing cycle until 
        // the clock hits the "end" time

        while (DateTime.Now < end)
        {
            // Show a message to
            // the user to first inhale 
            // and then to start a 
            // countdown of 4s that will be visible

            Console.Write("\nBreathe in... ");
            Countdown(4);

            // Show a message to
            // the user to first inhale 
            // and then to start a 
            // countdown of 6s that will be visible
            Console.Write("\nBreathe out... ");
            Countdown(6);

            Console.WriteLine();
            // To add a blank line space 
            // between the breathing cycles
        }
        // To call a closing message 
        // from the base class 
        // to end this activity

        EndMessage();
    }
}