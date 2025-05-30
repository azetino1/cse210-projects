public class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _completedCount;
    private int _bonus;

    public ChecklistGoal(string name, int points, int requiredCount, int bonus) 
        : base(name, points)
    {
        _requiredCount = requiredCount;
        _completedCount = 0;
        _bonus = bonus;
    }

    public override void RecordProgress()
    {
        _completedCount++;
        int totalPoints = (_completedCount == _requiredCount) ? _points + _bonus : _points;

        Console.WriteLine($"You recorded progress for {_name}. Total points earned: {totalPoints}");

        if (_completedCount >= _requiredCount)
            _isComplete = true;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{_name} - Completed {_completedCount}/{_requiredCount} times {(_isComplete ? "[X] Finished" : "[ ] Still working")}");
    }
}