using System;
using System.IO;

namespace ReadingFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\mcdon\Documents\Pride and Prejudice by Jane Austen.txt";

            //string entireBook = File.ReadAllText(filepath);
            string[] allLines = File.ReadAllLines(filepath);

            Console.WriteLine(allLines.Length);

            //for (int i = 0; i < allLines.Length; i++)
            //{
            //    if (i % 5 == 0 && i != 0)
            //    {
            //        Console.ReadKey();
            //    }
            //    Console.WriteLine(allLines[i]);

            //}

            foreach(var line in allLines) //Shows the file by chapter
            {
                if (line.Contains("Chapter") == true)
                {
                    Console.ReadKey();
                }
                Console.WriteLine(line);
            }

           // Console.WriteLine(entireBook);
            //Console.WriteLine(allLines);

        }
    }
}
