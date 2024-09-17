using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int sumNumber = -1;
        
        while (sumNumber != 0)
        {
            Console.Write("Enter a number: ");
            sumNumber = Convert.ToInt32(Console.ReadLine());
            if (sumNumber != 0)
            {
                numbers.Add(sumNumber);
            }
        }
        
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is {sum}.");

        double average = numbers.Average();
        Console.WriteLine($"The average is {average}.");
        
        int max = numbers.Max();
        Console.WriteLine($"The largest number is {max}.");
        
        int smallestPositive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is {smallestPositive}.");

        // Sort the list in ascending order
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}