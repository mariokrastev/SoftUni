using System;
class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Please input 5 numbers, separated by space: ");
        string[] userInput = Console.ReadLine().Split();
        double[] numbers = new double[5];
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = double.Parse(userInput[i]);
            sum += numbers[i];
        }
        Console.WriteLine("sum is: " + sum);
    }
}

