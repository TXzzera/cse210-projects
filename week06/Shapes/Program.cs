using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("blue", 5 );
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("yellow", 2.5, 3.5);
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("red", 2);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area.ToString("F2")} cm²");
        }

    }
}