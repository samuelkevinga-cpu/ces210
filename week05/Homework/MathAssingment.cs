public class MathAssignment : Assignment{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment(string studentName, string topic, string problems, string booksection)
    : base(studentName, topic)
    {
    _textbookSection = booksection;
    _problems = problems;
    }   
    public string GetHomeworkList()
    {
        return $"Student Name: {GetName()}, Topic: {GetTopic()}, Section: {_textbookSection}, Problems: {_problems},";
    }
}