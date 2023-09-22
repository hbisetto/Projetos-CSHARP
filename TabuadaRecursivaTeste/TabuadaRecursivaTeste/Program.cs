using System;

namespace TabuadaRecursivaTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deseja a tabuada de qual número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor máximo a ser multiplicado: ");
            int max = int.Parse(Console.ReadLine());

            //Tabuada de forma iterativa:

            for (int i = 0; i <= max; i++)
            {
                int res = num * i;
                Console.WriteLine(" {0} x {1} = {2}", num, i, res);
            }

            tabuadaRecursiva(num, max, 1);
        }

       public static void tabuadaRecursiva(int num, int max, int contador)
        {
            if (contador > max)
            {
                return;
            }

            int resultado = num * contador;

            tabuadaRecursiva(num, max, contador + 1);
        }
    }
}
