using System;

class PrintTheASCIITable
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            char symbol = (char)i;
            Console.WriteLine("{0}: {1}", i, symbol);
        }
    }

}