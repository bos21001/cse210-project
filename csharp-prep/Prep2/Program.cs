using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your course grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade;
        
        // Determine the letter grade
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        // Add the + or - to the letter grade
        if (grade % 10 >= 7 && letterGrade != "A" && letterGrade != "F")
        {
            letterGrade += "+";
        }
        else if (grade % 10 < 3 && letterGrade != "F")
        {
            letterGrade += "-";
        }
        
        Console.WriteLine($"Your letter grade is: {letterGrade}");
        
        // Determine if the student passed the course and give feedback
        if (grade >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("You learned a lot, but you didn't pass the course, keep trying on the next one!");
        }
    }
}