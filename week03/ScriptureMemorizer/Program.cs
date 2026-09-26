using System;

class Program
{
    static void Main(string[] args)
    {
        // Here the reference of the Scripture begins

        Reference reference = new Reference("2 Nephi", 9, 28, 29);

        // Here to define the context of the Scripture reference

        string text = "O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. But to be learned is good if they hearken unto the counsels of God.";

        //Here is the creation of the object of the Scripture

        Scripture scripture = new Scripture(reference, text);

        // Keep executing the program until the user types the "quit" option or until all the words are hidden, whichever comes first

        while (true)
        {
            Console.Clear();//Clear terminal

            //Mixing visible words and underscores
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");

            // Capturing answer from the user
            string input = Console.ReadLine();

            //Exit program if  the option "quit is typed" (case insensitive)
            if (input.ToLower() == "quit")
                break;

            //Pick and hide 3 random visible words
            scripture.HideRandomWords(3);

            //Check if the scripture is  already completely hidden
            if (scripture.IsCompletelyHidden())
            {
                // If previous instruction is true then show fully hidden scripture
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}