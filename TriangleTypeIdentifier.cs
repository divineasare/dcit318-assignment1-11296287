using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        Console.Write("Enter side 1: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double c = double.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Triangle Type: Equilateral");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Triangle Type: Isosceles");
        else
            Console.WriteLine("Triangle Type: Scalene");
    }
}
