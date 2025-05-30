using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        
        manager.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        manager.AddGoal(new EternalGoal("Read Scriptures", 100));
        manager.AddGoal(new ChecklistGoal("Attend Temple", 50, 10, 500));

     
        manager.DisplayGoals();
        manager.RecordGoalProgress("Read Scriptures");

        manager.DisplayGoals();
    }
}


