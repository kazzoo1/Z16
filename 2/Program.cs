using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = @"C:\New_folder";
        Directory.CreateDirectory(directoryPath);
        Console.WriteLine($"Directory created at {directoryPath}");
    }
}
