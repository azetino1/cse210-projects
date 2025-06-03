using System;

abstract class Activity
{
    public DateTime Date { get; set; }
    public int Duration { get; set; } // Duration in minutes

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }
    // Abstract methods for calculations
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();


     public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Duration} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}


