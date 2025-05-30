public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override void RecordProgress()
    {
        Console.WriteLine($"You recorded progress for {_name} and earned {_points} points!");
    }
}