using System;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber * secondNumber * thirdNumber > 0)
        {
            Console.WriteLine("+");
        }
        if (firstNumber * secondNumber * thirdNumber < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}

