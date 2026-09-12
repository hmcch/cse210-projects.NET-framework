using System;
// All main requirements covered
// Challenge #1 "Display Guess Count"  covered,
// go to specific lines of code 63,64,94
// Challenge #2 "Want to play again?" covered 
// go to specific lines of code 96-107
class Program
{
    static void Main(string[] args)
    {
        // C# Programming Exercise 3: Loops
        {// CORE REQUIREMENT #1

            // Ask the magic number and the user number
            // Console.Write("What is the magic number? ");
            // string computerNumber = Console.ReadLine();
            // int computerNum = int.Parse(computerNumber);

            // Console.Write("What is your guess? ");
            // string guessNumber = Console.ReadLine();
            // int guessNum = int.Parse(guessNumber);
            // // Comparing user number against magic/computer number
            // if (guessNum < computerNum)
            // {
            //     Console.Write("Higher");
            // }
            // else if (guessNum > computerNum)
            // {
            //     Console.Write("Lower");
            // }
            // else
            // {
            //     Console.Write("You guessed it!");
            // }
        }
        //  CORE REQUIREMENT 2 

        // Console.Write("What is the magic number? ");
        // string computerNumber2 = Console.ReadLine();
        // int computerNum2 = int.Parse(computerNumber2);

        // Console.Write("What is your guess? ");
        // string guessNumber2 = Console.ReadLine();
        // int guessNum2 = int.Parse(guessNumber2);

        // while (guessNum2 != computerNum2)
        // {
        //     if (guessNum2 < computerNum2)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (guessNum2 > computerNum2)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        // }

        // Console.Write("What is your guess? ");
        // guessNum2 = int.Parse(Console.ReadLine());
        // Core requirement 3 (keep looping as long as the guess does not match the key number)


        // CORE REQUIREMENT #3
        {
            while (true)
            {
                int countGuesses;
                countGuesses = 0;
                int guess;
                guess = -1;

                Random randomGenerator = new Random();
                int keyNumber = randomGenerator.Next(1, 101);

                while (guess != keyNumber)
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    countGuesses += 1;

                    if (keyNumber > guess)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (keyNumber < guess)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You guessed it!");
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"It took you {countGuesses} guesses");// Challenge #1 "Display guess count"

                Console.WriteLine();
                Console.Write("Do you want to play again? (yes or no): ");// Challenge #2 "Want to play again?"
                string keepPlaying = Console.ReadLine();
                if (keepPlaying == "no")
                {
                    Console.Write("Thanks for playing.");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }

}