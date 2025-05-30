public class SimpleGoal : Goal
{
    private bool _isComplete; 

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {
        //Constructor is identical to the base Goal class
    }

     public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        //The simple goal is now completed. We will mark it as done, and return how any points it is worth.
        _isComplete = true;
        return _points;
    }