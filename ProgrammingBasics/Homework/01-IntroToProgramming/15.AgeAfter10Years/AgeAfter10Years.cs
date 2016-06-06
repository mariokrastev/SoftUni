using System;

class AgeAfter10Years
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your birthday: ");
        string bday = Console.ReadLine();
        DateTime birthday = DateTime.Parse(bday);
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - birthday.Year;
        if (birthday.DayOfYear < currentDate.DayOfYear)
        {
            Console.WriteLine("Now: {0}", age);
            Console.WriteLine("After 10 years: {0}", age + 10);
        }
        else
        {
            Console.WriteLine("Now: {0}", age - 1);
            Console.WriteLine("After 10 years: {0}", age + 9);
        }
        


    }
}

