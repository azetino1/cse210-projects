using System;

// stores comment details
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

// Video reference
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the total number of comments
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Method to display video details
    public void DisplayInfo()
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

// Main Program Execution
class Program
{
    static void Main(string[] args)
    {
        // List to store videos
        List<Video> videos = new List<Video>
        {
            new Video("United States: A Great Nation", "John Merback", 600),
            new Video("Cooking with Passion", "Chef Barbara", 450),
            new Video("Tech Review: Latest Gadgets", "TechOne", 780)
        };

        // Adding comments to videos
        videos[0].AddComment(new Comment("Mark", "Indeed, what a great nation it is."));
        videos[0].AddComment(new Comment("Bob", "Great video!"));
        videos[0].AddComment(new Comment("Fernando", "Grateful for the opportunities"));

        videos[1].AddComment(new Comment("David", "This recipe looks delicious!"));
        videos[1].AddComment(new Comment("Nancy", "I tried this, and it's amazing."));
        videos[1].AddComment(new Comment("Frank", "Looking forward to more recipes."));

        videos[2].AddComment(new Comment("Lisa", "Thanks for the in-depth review."));
        videos[2].AddComment(new Comment("Abraham", "Very informative!"));
        videos[2].AddComment(new Comment("Isabel", "What do you think about the battery life?"));

        // Loop through videos and display their details
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}