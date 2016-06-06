using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter four digit number: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 9999)
        {
            Console.WriteLine("Wrong number! "); return;
        }
        else
        {
            if (number < 1000)
            {
                Console.WriteLine("Wrong number! "); return;
            }

            int firstNumber = number % 10;
            int secondNumber = (number / 10) % 10;
            int thirdNumber = (number / 100) % 10;
            int fourthNumber = (number / 1000) % 10;
            int sumOfDigits = firstNumber + secondNumber + thirdNumber + fourthNumber;

            Console.WriteLine("The sum of all the digits of the number {0} is {1}", number, sumOfDigits);
            Console.WriteLine("Number in reversed order : {0}{1}{2}{3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
            Console.WriteLine("Puts the last digit in the first position : {0}{1}{2}{3}", firstNumber, fourthNumber, thirdNumber, secondNumber);
            Console.WriteLine("Exchange the second and third digits : {0}{1}{2}{3}", fourthNumber, secondNumber, thirdNumber, firstNumber);


        }
    }
}

