using System;

class PointInsideACirleAndOutsideOfARectangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter number \"x\": ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter number \"y\": ");
        double y = double.Parse(Console.ReadLine());
        // (x - center_x)^2 + (y - center_y)^2 < radius^2.
        bool isInCirle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(1.5, 2);
        bool outOfRectngle = x > 1 && x <= 5 && y > -1 && y <= 1;

        if (isInCirle == true && outOfRectngle != true)
        {
            Console.WriteLine("inside K & outside of R: yes");
        }
        else
        {
            Console.WriteLine("inside K & outside of R: no");

        }
    }
}
