namespace learning06;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 5, 10));
        shapes.Add(new Circle("Green", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetColor()} shape is {shape.GetArea()}");
        }
    }
}