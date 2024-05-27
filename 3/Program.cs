using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string fileName = "textfile.txt";
        string[] lines = { "Hello, World!", "Welcome to C#", "This is a line", "Another line", "Last line" };
        File.WriteAllLines(fileName, lines);

        Console.WriteLine(File.ReadAllText(fileName));
        Console.WriteLine($"Number of lines: {lines.Length}");
        foreach (var line in lines)
        {
            Console.WriteLine($"{line}: {line.Length} characters");
        }

        // Удаление последней строки
        File.WriteAllLines("newfile.txt", lines.Take(lines.Length - 1));
        Console.WriteLine("Contents of the new file without the last line:");
        Console.WriteLine(File.ReadAllText("newfile.txt"));
    }
}
