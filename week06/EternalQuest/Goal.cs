public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    // Mark as abstract if every derived class must implement it
    public abstract void RecordProgress();

    // Mark as virtual if derived classes can override but don't have to
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"{_name} - {(_isComplete ? "[X] Completed" : "[ ] In Progress")}");
    }
}