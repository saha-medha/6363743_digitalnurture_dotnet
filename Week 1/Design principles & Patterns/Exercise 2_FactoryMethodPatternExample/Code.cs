using System;
public interface IShape
{
    void Draw();
}
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}
public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}
public class ShapeFactory
{
    public IShape GetShape(string shapeType)
    {
        switch (shapeType.ToLower())
        {
            case "circle":
                return new Circle();
            case "square":
                return new Square();
            default:
                throw new ArgumentException("Unknown shape type");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ShapeFactory factory = new ShapeFactory();

        IShape shape1 = factory.GetShape("circle");
        shape1.Draw();

        IShape shape2 = factory.GetShape("square");
        shape2.Draw();
    }
}
