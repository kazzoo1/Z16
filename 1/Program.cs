using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "numbers.txt";
        var numbers = File.ReadAllLines(filePath).Select(double.Parse).ToList();
        double sum = numbers.Sum();
        double difference = numbers.First() - numbers.Last();
        Console.WriteLine($"Sum: {sum}, Difference between first and last: {difference}");
    }
}
