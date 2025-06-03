using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
        new Running(new DateTime(2025, 6, 2), 30, 3.0),
        new Cycling(new DateTime(2025, 6, 2), 45, 15.0),
        new Swimming(new DateTime(2025, 6, 2), 20, 10)
        };
        foreach (var activity in activities)
        {
        Console.WriteLine(activity.GetSummary());
        }
    }
}