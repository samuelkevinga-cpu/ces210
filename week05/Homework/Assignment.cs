using System.Dynamic;

public class Assignment
{
    private string _stundentName = "";
    private string _topic = "";
    public Assignment (string studentName, string topic)
    {
        _stundentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"NAME: {_stundentName}, Topic: {_topic}";
    }
    public void SetName(string name)
    {
        _stundentName = name;
    }
    public string GetName()
    {
        return _stundentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetTopic()
    {
        return _topic;
    }
}