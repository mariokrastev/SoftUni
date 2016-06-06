using System;

class CirlePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter circle's radius: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * (r * r);
        Console.WriteLine("The perimeter is: {0:F2}\nThe area is: {1:F2}", perimeter, area);
    }
}

