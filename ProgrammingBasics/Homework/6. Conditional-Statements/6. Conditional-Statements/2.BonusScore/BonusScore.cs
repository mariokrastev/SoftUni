using System;

class BonusScore
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        if ((number <= 0) | (number > 9))
        {
            Console.WriteLine("Invalid Score!");
        }
        if ((number > 0) && (number <= 3))
        {
            number *= 10;
            Console.WriteLine(number);
        }
        if ((number >= 4) && (number <= 6))
        {
            number *= 100;
            Console.WriteLine(number);
        }
        if ((number >= 7) && (number <= 9))
        {
            number *= 1000;
            Console.WriteLine(number);
        }

    }
}

