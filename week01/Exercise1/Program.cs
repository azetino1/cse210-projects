using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        //Prompt the user for their first name
        Console.WriteLine("What is your first name?");
        string firstname = Console.ReadLine();

       //Prompt the user for their last name
        Console.WriteLine("What is your last name?");
        string lastname = Console.ReadLine();

      //Display fullname  
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

    }
}
