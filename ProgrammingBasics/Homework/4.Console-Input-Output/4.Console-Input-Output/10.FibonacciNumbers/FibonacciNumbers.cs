using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        long n;

        string output = "\nThe first {0} members of the Fibonacci sequence are:\n{1}\n";

        double phi = (1 + Math.Sqrt(5)) / 2;

        do
            Console.WriteLine("Enter n: ");
        while (!long.TryParse(Console.ReadLine(), out n) || n <= 0);

        double[] nums = new double[n];

        for (int i = 0; i < n; i++)
            nums[i] = Math.Round((Math.Pow(phi, i) - Math.Pow((1 - phi), i)) / Math.Sqrt(5));

        Console.WriteLine(output, n, string.Join(", ", nums));
    }



}




