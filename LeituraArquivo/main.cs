using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "teste.txt";
        string path2 = "teste2.txt";
        
      if(File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {path} não foi encontrado.");
        }

        Console.WriteLine();
      
        if(File.Exists(path2))
        {
            string[] lines = File.ReadAllLines(path2);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine($"O arquivo {path2} não foi encontrado.");
        }
    }
}