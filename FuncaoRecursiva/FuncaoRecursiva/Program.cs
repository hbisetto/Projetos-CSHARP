using System;

namespace FuncaoRecursiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para o cálculo fatorial: ");
            int num = int.Parse(Console.ReadLine());
            int fat = fatIterativo(num);
            Console.WriteLine(fat);

            Console.WriteLine("Digite um novo número para o cálculo fatorial: ");
            num = int.Parse(Console.ReadLine());
            fat = fatRecursivo(num);
        }

        public static int fatIterativo(int numero) //Usando função iterativa
        {
            int resultado = 1;
            while (numero >= 1)
            {
                resultado = resultado * numero;
                numero = numero - 1;
            }
            return resultado;
        }

        public static int fatRecursivo(int numero) //Usando função recursiva
        {
            if (numero == 1 || numero == 0)
                return 1;
            else
                return numero * fatRecursivo(numero - 1);
        }
    }
}
