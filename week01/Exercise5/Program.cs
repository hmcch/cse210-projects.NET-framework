using System;
// Every main requirement covered
class Program
{
    static void Main(string[] args)
    {
        // Main function to call each of the next functions

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int sqrtNumber = SquareNumber(userNumber);

        DisplayResult(userName, sqrtNumber);
    }


    // DisplayWelcome Function
    static void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the program!");
    }

    // PromptUserName Function
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // PromptUserNumber Function
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    // SquareNumber Function
    static int SquareNumber(int number)
    {
        int sqrt = number * number;
        return sqrt;
    }

    // DisplayResult Function
    static void DisplayResult(string userName, int sqrt)
    {
        Console.WriteLine($"{userName}, the square number of your number is {sqrt}");
    }
}