using System;
using System.Dynamic;
using OrientacaoObjetoTeste;

namespace Livros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro x, y;
            x = new Livro();
            y = new Livro();

            Console.WriteLine("Adicionando dois livros:");
            Console.WriteLine();
            Console.WriteLine("Primeiro Livro");
            Console.Write("Nome do livro: ");
            x.Titulo = Console.ReadLine();
            Console.Write("Nome do autor: ");
            x.Autor = Console.ReadLine();
            Console.Write("Código: ");
            x.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Preço :");
            x.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade? ");
            x.Qtde = int.Parse(Console.ReadLine());
            Console.WriteLine("Pronto! Vamos para o segundo livro.");
            Console.WriteLine();

            Console.WriteLine("Segundo Livro");
            Console.Write("Nome do livro: ");
            y.Titulo = Console.ReadLine();
            Console.Write("Nome do autor: ");
            y.Autor = Console.ReadLine();
            Console.Write("Código: ");
            y.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Preço :");
            y.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade? ");
            y.Qtde = int.Parse(Console.ReadLine());
            Console.WriteLine("Pronto!");

            Console.WriteLine();
            Console.WriteLine("Dados do primeiro livro inserido: ");
            Console.WriteLine($"{x.Titulo}, autor {x.Autor}, codigo {x.Codigo}, preço {x.Preco:F2}, quantidade {x.Qtde}");


        }
    }
}
