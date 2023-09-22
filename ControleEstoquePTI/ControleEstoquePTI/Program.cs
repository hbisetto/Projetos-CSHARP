using System;
using TAD;


namespace ControleDeEstoque
{
    internal class Program
    {
        private static Livro livro1, livro2, livro3; // foi declarado assim para todas as funções terem acesso.
        static void Main(string[] args)
        {
            livro1 = new Livro();
            livro2 = new Livro();
            livro3 = new Livro();

            livro1.posicao = 1;
            livro1.posicaobool = true; //true quando está disponível; false quando a posicao foi ocupada
            livro2.posicao = 2;
            livro2.posicaobool = true;
            livro3.posicao = 3;
            livro3.posicaobool = true;

            int opcao = 6;

            while (opcao != 0)
            {
                Menu();
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Novo();
                        break;
                    case 2:
                        Listar();
                        break;
                    case 3:
                        Remover();
                        break;
                    case 4:
                        Entrada();
                        break;
                    case 5:
                        Saida();
                        break;
                    default:
                        break;
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("[1] Novo                   [4] Entrada Estoque");
            Console.WriteLine("[2] Listar Produtos        [5] Saída Estoque  ");
            Console.WriteLine("[3] Remover Produtos       [0] Sair           ");
        }

        public static void Novo()
        {
            if (livro1.posicaobool == true)
            {
                Console.WriteLine();
                Console.WriteLine("Informe o nome do livro: ");
                livro1.titulo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Informe o preço: ");
                livro1.preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o autor(a): ");
                livro1.autor = Console.ReadLine();
                Console.WriteLine("Informe o gênero: ");
                livro1.genero = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Livro adicionado com sucesso!");
                livro1.posicaobool = false;
            }
            else if (livro2.posicaobool == true)
            {
                Console.WriteLine();
                Console.WriteLine("Informe o nome do livro: ");
                livro2.titulo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Informe o preço: ");
                livro2.preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o autor(a): ");
                livro2.autor = Console.ReadLine();
                Console.WriteLine("Informe o gênero: ");
                livro2.genero = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Livro adicionado com sucesso!");
                livro2.posicaobool = false;

            }
            else if (livro3.posicaobool == true)
            {
                Console.WriteLine();
                Console.WriteLine("Informe o nome do livro: ");
                livro3.titulo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Informe o preço: ");
                livro3.preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o autor(a): ");
                livro3.autor = Console.ReadLine();
                Console.WriteLine("Informe o gênero: ");
                livro3.genero = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Livro adicionado com sucesso!");
                livro3.posicaobool = false;

            }
            else
            {
                Console.WriteLine("Não é possível adicionar mais livros no estoque. Limite de armazenamento do protótipo.");
            }
        }

        public static void Listar()
        {
            Console.WriteLine();
            if (livro1.posicaobool == false)
            {
                Console.WriteLine("{0} . {1} ({2:F2}) - {3} no estoque", livro1.posicao, livro1.titulo, livro1.preco, livro1.quantidade);
            }
            if (livro2.posicaobool == false)
            {
                Console.WriteLine("{0} . {1} ({2:F2}) - {3} no estoque", livro2.posicao, livro2.titulo, livro2.preco, livro2.quantidade);
            }
            if (livro3.posicaobool == false)
            {
                Console.WriteLine("{0} . {1} ({2:F2}) - {3} no estoque", livro3.posicao, livro3.titulo, livro3.preco, livro3.quantidade);
            }
        }

        public static void Remover()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a posição do livro: ");
            int pos = int.Parse(Console.ReadLine());
            if (pos == 1)
            {
                livro1.titulo = null;
                livro1.autor = null;
                livro1.genero = null;
                livro1.preco = 0;
                livro1.quantidade = 0;
                livro1.posicaobool = true; // =  removido
            }
            if (pos == 2)
            {
                livro2.titulo = null;
                livro2.autor = null;
                livro2.genero = null;
                livro2.preco = 0;
                livro2.quantidade = 0;
                livro2.posicaobool = true; // =  removido
            }
            if (pos == 3)
            {
                livro3.titulo = null;
                livro3.autor = null;
                livro3.genero = null;
                livro3.preco = 0;
                livro3.quantidade = 0;
                livro3.posicaobool = true; // =  removido
            }

        }

        public static void Entrada()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a posição do livro: ");
            int pos_ = int.Parse(Console.ReadLine());
            switch (pos_)
            {
                case 1:
                    if (livro1.posicaobool == false)
                    {
                        Console.WriteLine("Informe a quantidade de Entrada: ");
                        livro1.quantidade = int.Parse(Console.ReadLine());
                    }
                    break;
                case 2:
                    if (livro2.posicaobool == false)
                    {
                        Console.WriteLine("Informe a quantidade de Entrada: ");
                        livro2.quantidade = int.Parse(Console.ReadLine());
                    }
                    break;
                case 3:
                    if (livro3.posicaobool == false)
                    {
                        Console.WriteLine("Informe a quantidade de Entrada: ");
                        livro3.quantidade = int.Parse(Console.ReadLine());
                    }
                    break;
                default:
                    break;
            }
        }

        public static void Saida()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a posição do livro: ");
            int pos_ = int.Parse(Console.ReadLine());
            switch (pos_)
            {
                case 1:
                    if (livro1.posicaobool == false)
                    {
                        Console.WriteLine("Informe a quantidade de Saída: ");
                        int qtde = int.Parse(Console.ReadLine());
                        livro1.quantidade = livro1.quantidade - qtde;
                    }
                    break;
                case 2:
                    if (livro2.posicaobool == false)
                    {
                        Console.WriteLine("Informe a quantidade de Saída: ");
                        int qtde = int.Parse(Console.ReadLine());
                        livro2.quantidade = livro2.quantidade - qtde;
                    }
                    break;
                case 3:
                    if (livro3.posicaobool == false)
                    {
                        Console.WriteLine("Informe a quantidade de Saída: ");
                        int qtde = int.Parse(Console.ReadLine());
                        livro3.quantidade = livro3.quantidade - qtde;
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
