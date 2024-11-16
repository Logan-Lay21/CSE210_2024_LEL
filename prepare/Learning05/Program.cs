using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Square s = new Square("blue", 8);
        Rectangle r = new Rectangle("red", 4, 8);
        Circle c = new Circle("green", 4);

        // Console.WriteLine(s.GetColor());
        // Console.WriteLine(s.GetArea());

        // Console.WriteLine(r.GetColor());
        // Console.WriteLine(r.GetArea());

        // Console.WriteLine(c.GetColor());
        // Console.WriteLine(c.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}