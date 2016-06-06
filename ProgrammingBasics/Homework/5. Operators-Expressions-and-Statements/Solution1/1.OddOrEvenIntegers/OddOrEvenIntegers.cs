using System;

class OddOrEvenIntegers
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        bool odd = true;
        if (number % 2 == 0)
        {
            odd = false;
        }
        Console.WriteLine(odd);
    }
}

