﻿using System;

class NumberFromOneToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

