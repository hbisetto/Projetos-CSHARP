using System;

namespace BuscaBinária
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dados = { 26, 29, 31, 40, 48, 53, 54, 62, 68, 72 };
            int valor_procurado = 54;
            bool valor_encontrado = false;
            int inicio = 0;
            int fim = dados.Length - 1;
            int meio;
            do
            {
                meio = inicio + (fim - inicio) / 2;
                if (dados[meio] == valor_procurado)
                {
                    Console.WriteLine("Valor encontrado no índice " +
                    meio);
                    valor_encontrado = true;
                    break;
                }
                else if (dados[meio] > valor_procurado)
                {
                    fim = meio - 1;
                }
                else
                {
                    inicio = meio + 1;
                }
            } while (inicio <= fim);
            if (!valor_encontrado)
            {
                Console.WriteLine("Valor não encontrado");
            }
        }
    }
}
