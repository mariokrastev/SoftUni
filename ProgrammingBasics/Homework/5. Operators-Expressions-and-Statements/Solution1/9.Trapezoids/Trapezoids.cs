using System;

class Trapezoids
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a, b and h: ");

        double baseOne = double.Parse(Console.ReadLine());
        double baseTwo = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = ((baseOne + baseTwo) / 2.0) * h;
        Console.WriteLine("Area = " + area);
    }
}

