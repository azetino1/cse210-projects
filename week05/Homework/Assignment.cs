public class Assignment
{
    public string StudentName { get; }
    public string Topic { get; }

    public HomeworkAssignment(string studentName, string topic)
    {
        StudentName = studentName;
        Topic = topic;
    }

    public virtual string GetSummary()
    {
        return $"{StudentName} - {Topic}";
    }
}