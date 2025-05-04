using System;

class Program
{
    static void Main(string[] args)
    {
        //Greetings
        Console.WriteLine("Hello Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices.");

         //Initializes the Journal class 
         Journal journal = new Journal();

         //Acts as a control variable for looping through the menu
         bool running = true;

        //Keeps the program running until option Quit is selected
        while (running)
        {    
            // Options
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("what would you like to do?: ");
            
            //input handling for accuracy and error 
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

    }
}