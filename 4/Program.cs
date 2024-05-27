using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputPath = "binaryinput.txt";
        string outputPath = "binaryoutput.txt";
        var inputContent = File.ReadAllText(inputPath);
        var outputContent = inputContent.Replace('0', '1').Replace('1', '0');
        File.WriteAllText(outputPath, outputContent);
        Console.WriteLine($"Content written to {outputPath}");
    }
}
