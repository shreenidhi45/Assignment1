using System;
using System.Linq;

class CommandLineArgs
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide numbers as command-line arguments.");
            return;
        }

        double[] numbers = args.Select(arg => double.Parse(arg)).ToArray();

        int count = numbers.Length;
        double sum = numbers.Sum();
        double average = sum / count;
        double maximum = numbers.Max();
        double minimum = numbers.Min();

        Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Count: " + count);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Maximum: " + maximum);
        Console.WriteLine("Minimum: " + minimum);
    }
}