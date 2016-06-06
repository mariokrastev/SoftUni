using System;

class Rectangles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        double area = height * width;
        double perimeter = (2 * width) + (2 * height);
        Console.WriteLine("Perimeter = " + perimeter + " area = " + area);

    }
}

