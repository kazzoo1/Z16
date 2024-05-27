using System;
using System.IO;

class Program
{
    static void Main()
    {
        string targetDirectory = @"C:\Example_36tp";
        Directory.CreateDirectory(targetDirectory);
        Console.WriteLine($"Directory created: {targetDirectory}");

        string sourceDirectory = @"D:\Documents\TEST";
        var filesToCopy = Directory.GetFiles(sourceDirectory).Take(3);
        foreach (var file in filesToCopy)
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(targetDirectory, fileName);
            File.Copy(file, destFile);
            File.SetAttributes(destFile, FileAttributes.Hidden);
            Console.WriteLine($"File copied and hidden: {destFile}");
        }
    }
}
