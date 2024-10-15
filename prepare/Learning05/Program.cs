namespace Learning05;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Christopher Mendes", "Math");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();
        
        MathAssignment mathAssignment = new MathAssignment("Someone Test", "Math", "1.1", "1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        
        WritingAssignment writingAssignment = new WritingAssignment("Rafaela Mendes", "Writing", "The Best Writing Assignment");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}