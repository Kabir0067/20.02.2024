
Rectangle rectangle1 = new Rectangle();
Console.Write("Width: ");
rectangle1.Width = double.Parse(Console.ReadLine());
Console.Write("Height: ");
rectangle1.Height = double.Parse(Console.ReadLine());
Console.WriteLine("Area: " + rectangle1.GetArea());
public class Rectangle
{
    public double Width;
    public double Height;

    public double GetArea()
    {
        return Width * Height;
    }
}



