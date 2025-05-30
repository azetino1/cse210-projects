public class ChecklistGoal : Goal
{
    private int _amountCompleted; 
    private int _target; 
    private int _bonus; 

    public ChecklistGoal(string name, string desc, int points, int target, int bonus) : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted < _target)
        {
            return false;
        }
        return true;
    }
     public override int RecordEvent()
    {
       
        _amountCompleted++;
        if(_amountCompleted == _target){
            return _points + _bonus; 
        }
        return _points;
    }

    public override string GetStringRepresentation() {
        return $"Goal: {_name}\nDescription: {_description}\nType: Checklist\nCompleted:{IsComplete()}";
    }

    
}