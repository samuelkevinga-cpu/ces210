using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment ("Roberto Rodriguez", "Fractions", "8-19", "7.3");
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment1.GetWritingInformation());

        }
}