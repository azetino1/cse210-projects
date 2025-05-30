public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}

    public override void RecordProgress()
    {
        _isComplete = true;
        Console.WriteLine($"Goal completed! You earned {_points} points.");
    }
}