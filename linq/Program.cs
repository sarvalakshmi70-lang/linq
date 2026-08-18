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
        Console.WriteLine(string.Join(" ", numbers));

        var greaterThan50 = numbers.Where(n => n > 50);
        Console.WriteLine("\nNumbers greater than 50:");
        Console.WriteLine(string.Join(" ", greaterThan50));

        var multipliedNumbers = numbers.Select(n => n * 2);
        Console.WriteLine("\nNumbers multiplied by 2:");
        Console.WriteLine(string.Join(" ", multipliedNumbers));

        var ascending = numbers.OrderBy(n => n);
        Console.WriteLine("\nAscending Order:");
        Console.WriteLine(string.Join(" ", ascending));

        var descending = numbers.OrderByDescending(n => n);
        Console.WriteLine("\nDescending Order:");
        Console.WriteLine(string.Join(" ", descending));

        Console.WriteLine("\nFirst Number: " + numbers.First());
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
        Console.WriteLine("\nDistinct Numbers:");
        Console.WriteLine(string.Join(" ", uniqueNumbers));

        var firstFive = numbers.Take(5);
        Console.WriteLine("\nFirst 5 Numbers:");
        Console.WriteLine(string.Join(" ", firstFive));

        var skipFive = numbers.Skip(5);
        Console.WriteLine("\nSkip First 5 Numbers:");
        Console.WriteLine(string.Join(" ", skipFive));

        var reversed = numbers.AsEnumerable().Reverse();
        Console.WriteLine("\nReversed Numbers:");
        Console.WriteLine(string.Join(" ", reversed));
    }
}