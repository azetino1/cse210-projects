public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {
        
        
    }

     public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        
        _isComplete = true;
        return _points;
    }

     public override string GetStringRepresentation()
    {
        return $"Goal: {_name}\nDescription: {_description}\nType: Simple\nCompleted:{_isComplete}";
    }

    
}