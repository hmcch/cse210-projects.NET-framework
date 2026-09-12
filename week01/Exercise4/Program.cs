using System;
using System.Collections.Generic;
// Every Requirement covered
// Every challenge covered 
// Challenge #1 "Find the smallest positive number" 
// go to specific lines of code 66-77
// Challenge #2 "Sort the list from lowest to highest number" 
// go to specific lines of code 79-84.
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (num != 0)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        // Once you have a list, do the following:

        // Core Requirement #1
        // Compute the sum or total of the values inside the list.


        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Core Requirement #2
        // Compute the average of the values inside the list.


        int count = numbers.Count;
        // Using double to keep the decimals
        double average = (double)sum / count;

        Console.WriteLine($"The average is: {average}");

        // Core Requirement #3
        // Find the maximum or largest value inside the list


        int maximum = numbers[0];

        foreach (int element in numbers)
        {
            if (element > maximum)
            {
                maximum = element;
            }
        }
        Console.WriteLine($"The largest number is: {maximum}");

        // Challenge #1
        // Find smallest positive value

        int smallest = 999999;

        foreach (int element in numbers)
            if (element > 0 && element < smallest)
            {
                smallest = element;
            }

        Console.WriteLine($"The smallest positive number is: {smallest}");

        // Stretch Challenge #2
        // Sort list from lowest to highest value

        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        numbers.ForEach(Console.WriteLine);

    }
}