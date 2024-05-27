using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string filtered = new string(sentence.Where(c => !char.IsDigit(c)).ToArray());
        string filePath = "textWithoutDigits.txt";
        File.WriteAllText(filePath, filtered);
        Console.WriteLine($"File written without digits: {filePath}");
        Console.WriteLine(File.ReadAllText(filePath));
    }
}
