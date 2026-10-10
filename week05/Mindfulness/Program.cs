using System;

class Program
{
    static void Main(string[] args)
    {
        //Initialize user choice at 0 so the loop can start without problems

        int choice = 0;

        //Loop keeps running until user types "4" to finish the execution

        while (choice != 4)

        {
            Console.Clear();//Clean terminal window every time menu loops back

            Console.WriteLine("Menu Options from the Mindfulness Program.");

            Console.WriteLine("1. Start Breathing Activity");

            Console.WriteLine("2. Start Reflection Activity");

            Console.WriteLine("3. Start Listing Activity");

            Console.WriteLine("4. Quit");

            Console.Write("Choose an option: ");

            //Read user text input and converts it into integer

            choice = int.Parse(Console.ReadLine());

            //If the data typed match a number choice, then:

            if (choice == 1)
            {
                //Creates a new instance object for BreathingActivity class

                BreathingActivity b = new BreathingActivity();

                b.Run();//Trigger breathing program loop logic
            }
            else if (choice == 2)
            {
                //Creates a new instance object for ReflectingActivity class

                ReflectionActivity r = new ReflectionActivity();

                r.Run();//Trigger reflection question loop logic
            }
            else if (choice == 3)
            {
                //Creates a new instance object for ListingActivity class

                ListingActivity l = new ListingActivity();

                l.Run();//Trigger dynamic text listing capture logic
            }

            //If the choice is "4" the loop breaks out and the program finishes.
        }
    }
}