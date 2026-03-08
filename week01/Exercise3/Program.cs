// Exercise 3: Loops - Guess My Number Game

string playAgain = "yes";

while (playAgain == "yes")
{
    //Generate a random number 1–100
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 101);

    int guess = 0;
    int guessCount = 0;

    // Loop until the user guesses correctly
    while (guess != magicNumber)
    {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());
        guessCount++;

        // Tell the user higher or lower
        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }

    //Show number of guesses
    Console.WriteLine($"It took you {guessCount} guesses.");

    //Ask to play again
    Console.Write("Do you want to play again? (yes/no): ");
    playAgain = Console.ReadLine();
}

Console.WriteLine("Thanks for playing!");
