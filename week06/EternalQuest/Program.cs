//I adjusted the menu for more clarity and added some formatting to the goal listing. 
//I also fixed a bug in the checklist goal where it would give the bonus points every time you recorded.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}