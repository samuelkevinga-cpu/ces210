// Exercise 4: Lists and Generics - Number Statistics

using System.Collections.Generic;

List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

int userInput = -1;

while (userInput != 0)
{
    Console.Write("Enter number: ");
    userInput = int.Parse(Console.ReadLine());

    if (userInput != 0)
    {
        numbers.Add(userInput);
    }
}

//Sum
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine($"The sum is: {sum}");

//Average
double average = (double)sum / numbers.Count;
Console.WriteLine($"The average is: {average}");

//Maximum
int largest = numbers[0];
foreach (int number in numbers)
{
    if (number > largest)
    {
        largest = number;
    }
}
Console.WriteLine($"The largest number is: {largest}");

//Smallest positive number
int smallestPositive = int.MaxValue;
foreach (int number in numbers)
{
    if (number > 0 && number < smallestPositive)
    {
        smallestPositive = number;
    }
}

if (smallestPositive != int.MaxValue)
{
    Console.WriteLine($"The smallest positive number is: {smallestPositive}");
}

//Sort and display
numbers.Sort();
Console.WriteLine("The sorted list is:");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
