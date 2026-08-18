using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>()
        {
            10, 20, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };

        Console.WriteLine("Original Numbers:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        var greaterThan50 = numbers.Where(n => n > 50);

        Console.WriteLine("Numbers greater than 50:");

        foreach (int number in greaterThan50)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        var multipliedNumbers = numbers.Select(n => n * 2);

        Console.WriteLine("Numbers multiplied by 2:");

        foreach (int number in multipliedNumbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        var ascending = numbers.OrderBy(n => n);

        Console.WriteLine("Ascending Order:");

        foreach (int number in ascending)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        var descending = numbers.OrderByDescending(n => n);

        Console.WriteLine("Descending Order:");

        foreach (int number in descending)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("First Number: " + numbers.First());

        Console.WriteLine("Last Number: " + numbers.Last());

        Console.WriteLine("Count: " + numbers.Count());

        Console.WriteLine("Sum: " + numbers.Sum());

        Console.WriteLine("Average: " + numbers.Average());

        Console.WriteLine("Minimum: " + numbers.Min());

        Console.WriteLine("Maximum: " + numbers.Max());

        Console.WriteLine("Any number greater than 90: " +
                          numbers.Any(n => n > 90));

        Console.WriteLine("All numbers greater than 5: " +
                          numbers.All(n => n > 5));

        Console.WriteLine("Contains 50: " +
                          numbers.Contains(50));

        var uniqueNumbers = numbers.Distinct();

        Console.WriteLine("Distinct Numbers:");

        foreach (int number in uniqueNumbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        var firstFive = numbers.Take(5);

        Console.WriteLine("First 5 Numbers:");

        foreach (int number in firstFive)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        var skipFive = numbers.Skip(5);

        Console.WriteLine("Skip First 5 Numbers:");

        foreach (int number in skipFive)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\n");

        var reversed = numbers.AsEnumerable().Reverse();

        Console.WriteLine("Reversed Numbers:");

        foreach (int number in reversed)
        {
            Console.Write(number + " ");
        }
    }
}