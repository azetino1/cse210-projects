public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Lets create a goal!\n What type of goal would you like to add? (Enter Number)");
        Console.WriteLine("1) Simple Goal - Do this goal once");
        Console.WriteLine("2) Eternal Goal - Continue to work on this goal");
        Console.WriteLine("3) Checklist Goal - Do this goal a certain number of times");

        bool validInput = false; // This is for error checking, if the user enters an incorrect number. 
        Console.WriteLine("Enter a number (1 = Simple goal, 2 = Eternal goal, 3 = Checklist goal):");
        string a = Console.ReadLine();
