namespace Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        
        fraction.SetTop(10);
        fraction.SetBottom(3);
        
        System.Console.WriteLine(fraction.GetFractionString());
        System.Console.WriteLine(fraction.GetFractionValue());
    }
}