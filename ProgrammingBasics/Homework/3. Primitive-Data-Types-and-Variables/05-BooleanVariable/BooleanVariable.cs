using System;

class BooleanVariable
{
    static void Main(string[] args)
    {
        int male = 1;
        int female = 2;
        bool isFemale = (male < female);
        Console.WriteLine("My gander is male: {0}", isFemale);
    }
}

