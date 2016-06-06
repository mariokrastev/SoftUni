using System;

class ExtractBitNumber3
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int p = 3;

        int nRightp = number >> p;
        int bit = nRightp & 1;
        Console.WriteLine(bit);
    }
}

