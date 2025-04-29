using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        //Ask the user for their grade percentage
        Console.WriteLine("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        String letter;

        //Determine the letter grade 
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {  
             letter = "B";
        }
        else if (gradePercentage >= 70)
        {  
             letter = "C";
        }
        else if (gradePercentage >= 60)
        {   
            letter = "D";
        }
        else 
        { 
            letter = "F";
        }

        //Print letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

       //Check if the user passed the course
       if (gradePercentage >= 70)
       {
        Console.WriteLine("Congratulations, you passed the course!");
       }
       else 
       {
        Console.Write("Keep trying! You'll get it next time.");
       }
}
}

