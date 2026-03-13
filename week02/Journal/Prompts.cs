class Prompts
{
    private List<string> _promptsList;
    public Prompts()
    {
        _promptsList = new List<string>();
        _promptsList.Add("Who was the most interesting person I interacted with today?");
        _promptsList.Add("What was the best part of my day?");
        _promptsList.Add("How did I see the hand of the Lord in my life today?");
        _promptsList.Add("What was the strongest emotion I felt today?");
        _promptsList.Add("If I had one thing I could do over today, what would it be?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptsList.Count);
        return _promptsList[index];
        }
    }