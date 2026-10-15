using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        //Create a new object instance of the GoalManager class using the "new" keyword

        gm.Start();
        // With the use of the '.' it calls the "Start" method on the new manager object.

        // By the use of this the control is transferred to GoalManager,
        // that will execute and display the menu options list for the user.
    }
}