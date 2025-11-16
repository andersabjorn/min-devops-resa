using System;

struct Rectangle(double Width, double Height)
{
    public double Area() => Width * Height;
    public double Perimeter() => 2 * (Width + Height);
    public bool IsSquare() => Width == Height;
}

class Program
{
    static void Main()
    {
        var r1 = new Rectangle(4, 5);
        var r2 = new Rectangle(3, 3);

        Console.WriteLine($"{r1.Area()} {r1.Perimeter()} {r1.IsSquare()}");
        Console.WriteLine($"{r2.Area()} {r2.Perimeter()} {r2.IsSquare()}");
    }
}
