using System;

class PracticeFloatingPointNumbers
{
    static void Main(string[] args)
    {
        const double pi = 3.14;
        Console.WriteLine("Enter r: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * pi * radius;
        Console.WriteLine(perimeter);


    }
}
