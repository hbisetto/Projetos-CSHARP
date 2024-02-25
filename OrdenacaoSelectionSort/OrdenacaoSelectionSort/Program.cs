using System;

namespace OrdenacaoSelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
            int min, temp;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;
                for (int pos = (i + 1); pos < vetor.Length; pos++)
                {
                    if (vetor[pos] < vetor[min])
                    {
                        min = pos;
                    }
                }
                if (vetor[i] != vetor[min])
                {
                    temp = vetor[i];
                    vetor[i] = vetor[min];
                    vetor[min] = temp;
                }
            }
        }
    }
}
