using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Ivanov";
        decimal amount = 1320m;
        string bankName = "Raiffeisen Bank";
        string iBAN = "BG80 BNBG 9661 1020 3456 78";
        long firstCardNum = 5105105105105100;
        long secondCardNum = 5125114155178151;
        long thirdCardNum = 5181356105674194;
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Middle Name: " + middleName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Available Amount: " + amount + " BGN");
        Console.WriteLine("Name of Bank: " + bankName);
        Console.WriteLine("IBAN: " + iBAN);
        Console.WriteLine("First card number: " + firstCardNum);
        Console.WriteLine("Second card number: " + secondCardNum);
        Console.WriteLine("Third card number: " + thirdCardNum);

    }
}

