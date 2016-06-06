using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        while (firstNumber < 0 || firstNumber > 500)
        {
            Console.WriteLine("Invalid number! Please enter number between 0 and 500: ");
            firstNumber = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        string binary = Convert.ToString(firstNumber, 2);
        Console.WriteLine("|{0,-10:X} |{1}|{2,10:#.##}|{3,-10:F3}|", firstNumber, binary.PadLeft(10, '0'), secondNumber,
        thirdNumber);

    }
}

