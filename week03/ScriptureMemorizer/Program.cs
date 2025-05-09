using System;

class Program
{
    static void Main()

    {   //Stores the scripture reference and holds the full verse text 
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(ref1, "Trust in the LORD with all your heart and lean not on your own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

       //loop contimues until all words in the scripture are hidden
        while (!scripture.AllWordsHidden())

        { //Clears the console and displays the scripture 
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input?.ToLower() == "quit") break;

        // User input
            scripture.HideRandomWords(2);
        }
        // Clears the console and displays final hiden scripture
        Console.Clear();
        Console.WriteLine(scripture);
        Console.WriteLine("\nAll words hidden. Program ended.");
    }
}