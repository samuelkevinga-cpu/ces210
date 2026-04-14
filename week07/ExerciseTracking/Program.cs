using System;

class Program
{
    static void Main(string[] args)
    {
        //In Program.cs you need to:
        //Create at least one object of each type with real values
        //Put them all in a single list
        //Loop through the list and call GetSummary() on each
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("2024-06-01", 30, 3.0)); // 3 miles in 30 minutes
        activities.Add(new Cycling("2024-06-02", 60, 15.0)); // 15 mph for 60 minutes
        activities.Add(new Swimming("2024-06-03", 45, 40)); // 40 laps in 45 minutes
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}