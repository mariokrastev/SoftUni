using System;

class PrintingNumbers
{
    static void PrintEvenNumbers()
    {
        int minRange = int.Parse(Console.ReadLine());
        int maxRange = int.Parse(Console.ReadLine());
        for (int i = minRange; i <= maxRange; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            else
            {
                Console.WriteLine(i);
            }

        }

    }
    static void Main()
    {
        PrintEvenNumbers();

    }

}