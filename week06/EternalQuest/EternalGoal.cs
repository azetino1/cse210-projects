public class EternalGoal : Goal
{
    private int _count;

    public EternalGoal(string name, string desc, int points) : base(name, desc, points)
    {
        
        
    }
    
    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        
        _count++;
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Goal: {_name}\nDescription: {_description}\nType: Eternal\nCompleted:{_count} Times";
    }

    
}