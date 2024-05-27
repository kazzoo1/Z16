using System;
using System.IO;

class Program
{
    static void Main()
    {
        string binaryFilePath = "binaryData.bin";
        double[] numbers = { -3.5, 2.4, -1.7, 4.2, 0.5 };
        using (BinaryWriter writer = new BinaryWriter(File.Open(binaryFilePath, FileMode.Create)))
        {
            foreach (var number in numbers)
            {
                writer.Write(number);
            }
        }

        using (BinaryReader reader = new BinaryReader(File.Open(binaryFilePath, FileMode.Open)))
        {
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                double num = reader.ReadDouble();
                Console.WriteLine(num);
            }
        }
    }
}
