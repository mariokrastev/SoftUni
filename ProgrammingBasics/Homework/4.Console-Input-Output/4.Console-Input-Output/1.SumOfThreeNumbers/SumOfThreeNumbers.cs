using System;

class SumOfThreeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Third Number: ");
        float thirdNumber = float.Parse(Console.ReadLine());
        double result = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("Result: " + result);
    }
}

