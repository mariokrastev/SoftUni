using System;

class PointInACirle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        bool isInsideCirle = (x - 0) * (x - 0) + (y - 0) * (y - 0) < 5 * 5 ? true : false;
        Console.WriteLine(isInsideCirle);
    }
}

