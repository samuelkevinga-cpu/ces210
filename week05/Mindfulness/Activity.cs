public class Activity
{
    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine("How long (in seconds), would you like for this session");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready ...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done");
        ShowSpinner(3);
        Console.WriteLine($"You have completed in {_duration} second the {_name} Activity");
    }
        public void ShowSpinner(int seconds)
    {
        List<string> spinnerFrames = new List<string> {"|", "/", "-", "\\"};
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerFrames[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= spinnerFrames.Count) i = 0;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            string backspaces = new string('\b', i.ToString().Length);
            string spaces = new string(' ', i.ToString().Length);
            Console.Write(backspaces + spaces + backspaces);
        }
    }
    public int GetDuration()
    {
        return _duration;
    }
}