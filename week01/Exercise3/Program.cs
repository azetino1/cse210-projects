using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

                // Prompt the user for a guess
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

 
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        
        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }







    }
}