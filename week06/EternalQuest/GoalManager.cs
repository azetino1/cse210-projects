using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoalProgress(string goalName)
    {
        Goal goal = _goals.Find(g => g._name == goalName);
        if (goal != null)
        {
            goal.RecordProgress();
            _score += goal._points;
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            goal.DisplayStatus();
        }
        Console.WriteLine($"Total Score: {_score}");
    }
}