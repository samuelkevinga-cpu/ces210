public class BreathingActivity : Activity
{   
    
    public BreathingActivity() : base ("Breathing Activity", "This activity will help you to stay in tuned with your inner self, clear your mind a breathe")
    {   }
    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe In");
            ShowCountDown(5);
            Console.WriteLine("Breathe Out");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}