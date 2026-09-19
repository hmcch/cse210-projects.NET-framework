using System;
using System.Collections.Generic;
using System.IO;
//Core Requirements exceeded, option added to erase the latest entry, lines of code 21, 51-54
class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string userOption = "";
        Console.WriteLine("Welcome to the Journal Program!");
        while (userOption != "5")
        {
            // While userOption is different from 5 always display this
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Delete last entry");
            Console.WriteLine("What would you like to do? ");
            // Read user input
            userOption = Console.ReadLine();
            // Starting loop with user input
            if (userOption == "1")
            {
                myJournal.AddEntry();
            }
            else if (userOption == "2")
            {
                myJournal.DisplayAll();
            }
            else if (userOption == "3")
            {
                Console.Write("What is the filename to load? ");
                string fileToLoad = Console.ReadLine();
                myJournal.LoadFromFile(fileToLoad);
            }
            else if (userOption == "4")
            {
                Console.WriteLine("Enter the filename to save: ");
                string fileToSave = Console.ReadLine();
                myJournal.SaveToFile(fileToSave);

            }
            else if (userOption == "5")
            {
                Console.WriteLine("Until the next time.");
            }
            else if (userOption == "6")
            {
                myJournal.EraseLatest();
            }
            else
            {
                Console.WriteLine("Invalid choice, you can only type numbers from 1 to 6");
            }
        }
    }
}