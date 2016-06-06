using System;

class ThirdDigitIsSeven
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        bool thirdDigit = true;
        if ((n / 100) % 10 == 7)
        {
            Console.WriteLine(thirdDigit);
        }
        else
        {
            thirdDigit = false;
            Console.WriteLine(thirdDigit);
        }
    }
}

