using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        double greaterNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number is: " + greaterNumber);
    }
}

