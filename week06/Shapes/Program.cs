using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle();
        circle1.SetColor("Brown");
        circle1.SetRadius(5);
        Square square1 = new Square();
        square1.SetColor("Red");
        square1.SetSide(8);
        Rectangle rectangle1 = new Rectangle();
        rectangle1.SetColor("Green");
        rectangle1.SetWidth(5);
        rectangle1.SetLenght(10);
        
        DisplayShapesAreas(square1);
        DisplayShapesAreas(rectangle1) ;
        DisplayShapesAreas(circle1);
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle1);
        shapes.Add(square1);
        shapes.Add(rectangle1);

        foreach (Shape shap in shapes)
        {
            double area = shap.GetArea();
        }

    }
    public static void DisplayShapesAreas(Shape shape)
    {
        double area = shape.GetArea();
        Console.WriteLine($"the shape is {shape.GetColor()} and his area is {shape.GetArea()}");
    }
}