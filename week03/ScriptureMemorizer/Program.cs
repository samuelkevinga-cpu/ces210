// I added a ScriptureLibrary class that stores multiple scriptures and selects one at random each time the program runs.
// I also implemented the stretch challenge of only hiding words that are not already hidden

using System;
using System.Runtime.InteropServices;

class Programs
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Scripture scripture = scriptureLibrary.GetRandomScripture();
        //Main loop to displat the scripture and hide words every time the user presses enter
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
        //If all words are hidden, the loop breaks 
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("You have hidden all the words");
                break;
            }
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
        //If the user enters quit, the loop breaks
            if (input.ToLower() == "quit")
            {
                break;
            }
            //hide 2 random words each time
            scripture.HideRandomWords(2);
        }
    }
}