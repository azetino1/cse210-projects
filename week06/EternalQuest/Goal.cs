public abstract class Goal
{
    public string _name;
    public int _points;
    public bool _isComplete;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    public abstract void RecordProgress();

    public virtual void DisplayStatus()
    {
        Console.WriteLine($"{_name} - {(_isComplete ? "[X] Completed" : "[ ] In Progress")}");
    }
}