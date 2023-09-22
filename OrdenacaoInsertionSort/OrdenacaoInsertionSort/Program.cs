using System;

namespace OrdenacaoInsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
            int num, pos_verificada;
            for (int pos = 1; pos < vetor.Length; pos++)
            {
                num = vetor[pos];
                pos_verificada = pos - 1;
                while (pos_verificada >= 0 && num < vetor[pos_verificada])
                {
                    vetor[pos_verificada + 1] = vetor[pos_verificada];
                    pos_verificada--;
                }
                vetor[pos_verificada + 1] = num;
            }
        }
    }
}
