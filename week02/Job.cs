using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        // Display the company name of job1
        Console.WriteLine(job1._company);

        // Create second job instance
        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2025;

        // Display the company name of job2
        Console.WriteLine(job2._company);
    }
}
