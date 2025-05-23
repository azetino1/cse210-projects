public class MathAssignment : Assignment
{
    public string TextbookSection { get; }
    public string Problems { get; }

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        TextbookSection = textbookSection;
        Problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {TextbookSection} Problems {Problems}";
    }
}