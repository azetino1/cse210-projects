public class ChecklistGoal : Goal
{
    private int _amountCompleted; // How many times the Checklist Goal was completed
    private int _target; // How many times do you want to complete this goal?
    private int _bonus; //If you hit the target, bonus moment.

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
