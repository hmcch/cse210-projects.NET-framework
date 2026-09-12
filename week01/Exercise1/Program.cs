using System;
// Every requirement fulfilled
class Program
{
    static void Main(string[] args)
    {

        // Get first name from user
        Console.Write("Type your first name? ");
        string firstName = Console.ReadLine();

        // Get surname from user
        Console.Write("Type your surname? ");
        string surName = Console.ReadLine();

        // Join last name and first name with the appropriate format.
        Console.WriteLine();
        Console.Write($"Your name is {surName}, {firstName} {surName}.");

    }
}