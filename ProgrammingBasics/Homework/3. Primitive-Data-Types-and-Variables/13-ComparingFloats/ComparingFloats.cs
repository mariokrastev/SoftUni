using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter  two numbers:");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool checkNum = Math.Abs(firstNumber - secondNumber) < eps;
        if (Math.Abs(firstNumber - secondNumber) < eps)
        {
            Console.WriteLine(checkNum);
        }
        else if (Math.Abs(firstNumber - secondNumber) >= eps)
        {
            Console.WriteLine(checkNum);
        }
    }
}

