using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine($"Fraction 1: {fraction1.GetTop()}/{fraction1.GetBottom()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetTop()}/{fraction2.GetBottom()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetTop()}/{fraction3.GetBottom()}");

        fraction1.SetTop(2);
        fraction1.SetBottom(3);
        Console.WriteLine($"Updated Fraction 1: {fraction1.GetTop()}/{fraction1.GetBottom()}");

        Console.WriteLine($"Fraction 1 as a string: {fraction1.GetFractionString()}");
        Console.WriteLine($"Fraction 1 as a decimal: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2 as a string: {fraction2.GetFractionString()}");
        Console.WriteLine($"Fraction 2 as a decimal: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3 as a string: {fraction3.GetFractionString()}");
        Console.WriteLine($"Fraction 3 as a decimal: {fraction3.GetDecimalValue()}");
    }
}