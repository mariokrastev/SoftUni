using System;

class CheckForAPlayCard
{
    static void Main(string[] args)
    {
        string card;

        do
        {
            Console.WriteLine("Enter card: ");
            card = Console.ReadLine();

            if (card.Length > 1)
            {
                Console.WriteLine("Enter only one symbol! ");
            }

        } while (card.Length > 1);

        const string deck = "23456789JQKA";
        double i = deck.IndexOf(card);
        if (i == -1)
        {
            Console.WriteLine("no");
        }
        else
        {
            Console.WriteLine("yes");
        }
    }
}
