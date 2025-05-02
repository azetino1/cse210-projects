using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Resume resume = new Resume("John Doe");
        resume.Jobs.Add(new Job("Software Engineer", "Microsoft", 2019, 2022));
         resume.Jobs.Add(new Job("Manager (Apple)", "Microsoft", 2022, 2023));
       
        resume.Display();
    }
}

public class Job
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        JobTitle = jobTitle;
        Company = company;
        StartYear = startYear;
        EndYear = endYear;
    }

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}

public class Resume
{
    public string PersonName { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    public Resume(string personName)
    {
        PersonName = personName;
    }

    public void Display()
    {
        Console.WriteLine($"Resume of {PersonName}");
        foreach (var job in Jobs)
        {
            job.Display();
        }
    }
}

    
