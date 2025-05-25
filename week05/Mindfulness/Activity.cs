public class Activity //Base Class, which the others inherit.
{
    private string _name;
    private string _description;
    protected int _duration; 

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage() 
    {
        Console.Clear();
        Console.WriteLine($"{_name}: {_description}"); 
        Console.Write("Enter desired activity duration (in Seconds): ");
        string duration = Console.ReadLine();
        try
        {
            _duration = int.Parse(duration); 
        }
        catch
        {
           
            Console.WriteLine("A whole number was not entered. Setting duration to default value of 60 seconds");
            _duration = 60;
        }
        Console.Write($"Get ready! Starting in ");
        ShowCountdown(5); 

    }

    public void DisplayEndingMessage()
    {
        Console.Write($"Great job! ");
        ShowSpinner(5); 

        Console.WriteLine($" ");
        Console.WriteLine($"You just completed {_duration} seconds of the {_name} activity!"); 
        Console.Write($"Returning to main menu in ");
        ShowCountdown(5);
    }

    public void ShowSpinner(int second)
    {
        for (int i = 0; i < second; i++)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

        }
    }

    public void ShowCountdown(int second) 
    {
        for (int i = second; i > 0; i--)
        {
            string numStr = i.ToString();
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b ");
            Console.Write(new string('\b', numStr.Length)); 
        }
    }

}