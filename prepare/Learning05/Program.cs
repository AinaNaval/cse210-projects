using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("blue", 3);
        Console.WriteLine(s.GetColor());
        Console.WriteLine(s.GetArea());

        Rectangle r = new Rectangle("Green", 10, 5);
        Console.WriteLine(r.GetColor());
        Console.WriteLine(r.GetArea());

        Circle c = new Circle("Yellow", 4);
        Console.WriteLine(c.GetColor());
        Console.WriteLine(c.GetArea());

        List<Shape> ShapeLists = new List<Shape>();
        ShapeLists.Add(s);
        ShapeLists.Add(r);
        ShapeLists.Add(c);

        foreach (Shape shape in ShapeLists)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}