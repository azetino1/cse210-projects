using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Prompt the user for the magic number
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        // Initializing with a value that ensures entry into the loop
        int guess = -1;

        while (guess != magicNumber)
        {

        //  // Prompt the user for the guess number
        Console.Write("What is your guess? ");
          guess = int.Parse(Console.ReadLine());

        
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
}   
