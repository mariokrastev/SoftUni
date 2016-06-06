using System;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        int nRightP = number >> position;
        int bit = nRightP & 1;
        Console.WriteLine(bit);

    }
}

