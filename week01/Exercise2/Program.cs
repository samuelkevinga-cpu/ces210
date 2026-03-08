// Exercise 2: If Statements - Grade Checker

Console.Write("Enter your grade percentage: ");
string input = Console.ReadLine();
int grade = int.Parse(input);

string letter;

if (grade >= 90)
{
    letter = "A";
}
else if (grade >= 80)
{
    letter = "B";
}
else if (grade >= 70)
{
    letter = "C";
}
else if (grade >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

// Stretch Challenge
string sign = "";
int lastDigit = grade % 10;

if (letter != "F")
{
    if (lastDigit >= 7)
    {
        sign = "+";
    }
    else if (lastDigit < 3)
    {
        sign = "-";
    }
}

// No A+ grade — A is the highest
if (letter == "A" && sign == "+")
{
    sign = "";
}

Console.WriteLine($"Your letter grade is: {letter}{sign}");

// Core Requirement 2: Pass/fail message
if (grade >= 70)
{
    Console.WriteLine("Congratulations, you passed the course!");
}
else
{
    Console.WriteLine("You did not pass. Keep working hard, you'll get it next time!");
}
