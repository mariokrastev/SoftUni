using System;

class SumOfNnumbers
{
    static void Main(string[] args)
    {
        sumValues();
        Console.ReadLine();
    }

    static void sumValues()
    {
        double sum = 0;
        double val;
        double n;
        double i;
        Console.Write("Enter number of values:");
        n = double.Parse(Console.ReadLine());
        for (i = 1; i <= n; i++)
        {
            Console.Write("Value " + i + ":");
            val = double.Parse(Console.ReadLine());
            sum += val;
        }

        Console.WriteLine("Total: " + sum);

    }


}




