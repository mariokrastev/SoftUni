using System;

    class MinMaxSum
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
        for (int row = 0; row < n; row++)
        {
            for (int column = 1; column <= n; column++)
            {
                Console.Write("{0} ", row + column);
            }
            Console.WriteLine();
        }


    }
    }

