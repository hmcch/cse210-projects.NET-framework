using System;
using System.Reflection.Metadata;
// Every main requirement accomplished
// Every challenge fulfilled,
// the specific lines of code are from 43 to 50.
class Program
{
    static void Main(string[] args)
    {   // Get grade information from user

        Console.Write("Type your grade in percentage (make sure to only use integer numbers): ");
        string percent = Console.ReadLine();
        int percentConverted = int.Parse(percent);

        string letter = "";

        // Calculate the corresponding grade based on the information typed by the user

        if (percentConverted >= 90)
        {
            letter = "A";
        }
        else if (percentConverted >= 80 && percentConverted <= 89)
        {
            letter = "B";
        }
        else if (percentConverted >= 70 && percentConverted <= 79)
        {
            letter = "C";
        }
        else if (percentConverted >= 60 && percentConverted <= 69)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int lastDigit = percentConverted % 10;

        if (lastDigit >= 7 && percentConverted >= 97 || percentConverted >= 97)// Stretch Challenge #1 Code to "Handle the +A grades"
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }
        else if (percentConverted <= 59 || letter == "F")// Stretch Challenge #2 Code to "Handle the F- and F+ grades"
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }
        else if (lastDigit >= 7)
        {
            Console.WriteLine($"Your grade is: {letter}+");
        }
        else if (lastDigit < 3)
        {
            Console.WriteLine($"Your grade is: {letter}-");
        }
        else
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }


        // Show a message to the user. The minimum percentage to pass the course is 70%

        if (percentConverted >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You failed the course. Keep improving and you will do it better for the next time.");
        }
    }
}