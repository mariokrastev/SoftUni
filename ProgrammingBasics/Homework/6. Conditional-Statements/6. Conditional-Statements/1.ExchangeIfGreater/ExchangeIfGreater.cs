using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        double firstValue = double.Parse(Console.ReadLine());
        double secondValue = double.Parse(Console.ReadLine());
        if (firstValue > secondValue)
        {
            Console.WriteLine(secondValue + " " + firstValue);
        }
        else
        {
            Console.WriteLine(firstValue + " " + secondValue);
        }
    }
}

