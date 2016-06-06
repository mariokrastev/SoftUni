using System;

class DivideBy7And5
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        bool checker = (number % 5 == 0) && (number % 7 == 0);
        Console.WriteLine(checker);


    }
}

