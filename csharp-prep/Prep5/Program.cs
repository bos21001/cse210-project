using System;

class Program
{
    static string DisplayWelcome()
    {
        return "Welcome to the program!";
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    
    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        return int.Parse(Console.ReadLine());
    }
    
    static int SquareNumber(int number)
    {
        return number * number;
    }
    
    static string DisplayResult(string name, int squaredNumber)
    {
        return $"Brother {name}, the square of your number is {squaredNumber}";
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(DisplayWelcome());
        
        string name = PromptUserName();
        int number = PromptUserNumber();
        
        int squaredNumber = SquareNumber(number);
        
        Console.WriteLine(DisplayResult(name, squaredNumber));
    }
}