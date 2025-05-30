using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Rectangle("Red", 2, 4));

        {
            Console.WriteLine($"Color: {s.GetColor()}, Area: {s.GetArea()}");
        }
    }
}