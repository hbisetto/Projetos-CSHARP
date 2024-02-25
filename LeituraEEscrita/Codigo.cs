using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "./teste.txt";
        string path2 = "./teste2.txt";
        
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

        Console.WriteLine("Por favor, insira um texto:");
        string userInput = Console.ReadLine();

        Console.WriteLine("Digite 's' para sobrescrever ou 'a' para adicionar:");
        char choice = Console.ReadKey().KeyChar;

        string path_3 = "saida.txt";

        try
        {
            switch (choice)
            {
                case 's':
                    File.WriteAllText(path_3, userInput + Environment.NewLine);
                    Console.WriteLine($"\nTexto salvo com sucesso no arquivo {path_3}!");
                    break;
                case 'a':
                    File.AppendAllText(path_3, userInput + Environment.NewLine);
                    Console.WriteLine($"\nTexto adicionado com sucesso ao arquivo {path_3}!");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro ao escrever no arquivo: {ex.Message}");
        }
    }
}
