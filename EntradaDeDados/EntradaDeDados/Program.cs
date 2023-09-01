using System;
using System.Threading.Channels;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine(); //Lendo uma linha inteira
            //string[] v = Console.ReadLine().Split(' ') -- outra maneira de fazer sem precisar declarar a string s
            string[] vet = s.Split(' '); //Transformando o string acima em um vetor de elementos separados
            string a = vet[0]; //Atribuindo uma variável para cada posição do vetor
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a + " " + b + " " + c);

        }
    }
}
