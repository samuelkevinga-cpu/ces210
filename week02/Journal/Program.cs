// Instead of saving to a plain text file, this program saves and loads journal entries using JSON format with the 
// Newtonsoft.Json library. This makes the file more readable and compatible with other programs.

using System;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
    Journal myJournal = new Journal();
    Prompts myPrompts = new Prompts();
    bool running = true;
    while (running)
        {        
        //Print the menu options}
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load last entry");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        //Ask the user to pick a number
        string choice = Console.ReadLine();
        //Do something based on their choice
        if (choice == "1")
            {
                string date = DateTime.Now.ToShortDateString();
                string prompt = myPrompts.GetRandomPrompt();
                Console.WriteLine(prompt);
                string entryText = Console.ReadLine(); 
                Entry entry = new Entry(date, prompt, entryText); 
                myJournal.AddEntry(entry);
            }
        else if (choice == "2")
            {
                myJournal.DisplayEntries();
            }
        else if (choice == "3")
            {
                Console.WriteLine("What is the filename you want to load from?");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
        else if (choice == "4")
            {
                Console.WriteLine("What is the filename you want to save to?");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
        else if (choice == "5")
            {
                running = false;
            }
        //Keep repeating until they choose Quit
        else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}