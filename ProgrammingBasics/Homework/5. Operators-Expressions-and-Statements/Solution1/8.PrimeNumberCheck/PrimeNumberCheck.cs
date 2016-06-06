using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("Enter number < 100 ! "); return;
            }
            int counter = (int)Math.Sqrt(num);
            bool isPrime = true;
            if (num > 1)
            {
                for (int i = 2; i <= counter; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }
            Console.WriteLine("Prime? " + isPrime);
        }
        catch
        {
            Console.WriteLine("Invalid Input.");
        }
    }

}
