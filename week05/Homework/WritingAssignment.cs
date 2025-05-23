public class WritingAssignment : Assignment

{
    public string Title { get; }

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        Title = title;
    }

    public string GetWritingInfo()
    {
        return $"{Title} by {StudentName}";
    }
}

