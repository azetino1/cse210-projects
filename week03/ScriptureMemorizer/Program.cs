using System;

class Program
{
    static void Main()
    {
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(ref1, "Trust in the LORD with all your heart and lean not on your own understanding. In all thy ways acknowledge him, and he shall direct thy paths");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input?.ToLower() == "quit") break;

            scripture.HideRandomWords(2);
        }

        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine("\nAll words hidden. Program ended.");
    }
}