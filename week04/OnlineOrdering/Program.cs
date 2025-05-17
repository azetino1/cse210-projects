using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}

// Abstract class defining a Media entity
abstract class Media
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Media(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public abstract void DisplayInfo(); // Abstract method to enforce implementation in derived classes
}

// Comment class
class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }

    public void Display()
    {
        Console.WriteLine($"- {CommenterName}: {Text}");
    }
}

// Video class inherits from Media
class Video : Media
{
    public int LengthInSeconds { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds) : base(title, author)
    {
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        comments.Add(new Comment(commenterName, text));
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {LengthInSeconds} sec");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        foreach (var comment in comments)
        {
            comment.Display();
        }

        Console.WriteLine();
    }
}

// Program execution
class Program
{
    static void Main()
    {
        // Creating videos
        List<Video> videos = new List<Video>
        {
            new Video("Exploring the Universe", "AstroGeek", 600),
            new Video("Cooking with Passion", "Chef Emily", 450),
            new Video("Tech Review: Latest Gadgets", "TechGuru", 780)
        };

        // Adding comments
        videos[0].AddComment("Alice", "Wow! Space is fascinating.");
        videos[0].AddComment("Bob", "Great explanation!");
        videos[0].AddComment("Charlie", "I want to be an astronaut!");

        videos[1].AddComment("David", "This recipe looks delicious!");
        videos[1].AddComment("Ella", "I tried this, and it's amazing.");
        videos[1].AddComment("Frank", "Looking forward to more recipes.");

        videos[2].AddComment("Grace", "Thanks for the in-depth review.");
        videos[2].AddComment("Henry", "Very informative!");
        videos[2].AddComment("Isabel", "What do you think about the battery life?");

        // Displaying video details and comments
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}