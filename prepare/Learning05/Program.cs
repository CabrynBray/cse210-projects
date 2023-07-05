using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("Yellow", 5);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Purple", 3, 5);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Blue", 10);
        shapes.Add(circle1);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }



    }
}