//// To exceed requirements, I added logic to ListingActivity to ensure 
// that empty inputs are not counted towards the total. I also 
// refined the animation logic in the base class to handle multi-digit 
// countdowns without leaving ghost characters on the screen.
using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            Console.WriteLine("-----------------------------------");
            input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (input == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (input == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }
    }
}