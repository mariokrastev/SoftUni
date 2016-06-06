using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before: a = " + a + " b = " + b);
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After: a = " + a + " b = " + b);

    }
}

