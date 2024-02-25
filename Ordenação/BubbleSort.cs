using System;

namespace OrdenacaoBubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 99, 82, 50, 67, 90, 20, 71, 8, 21, 18 };
            bool mudou = true;//1a otimização
            int ultimo = vetor.Length - 1;//2a otimização
            int ultimo_temp = vetor.Length - 1;
            while (mudou)
            {
                int pos = 0;
                mudou = false;
                int temp = 0;
                
                while (pos < ultimo)
                {
                    if (vetor[pos] > vetor[pos + 1])
                    {
                        
                        temp = vetor[pos]; //
                        vetor[pos] = vetor[pos + 1]; // troca
                        vetor[pos + 1] = temp; //
                        mudou = true;
                        ultimo_temp = pos;
                        Console.WriteLine("Passo a passo da ordenação Bubble Sort: ");
                        foreach (int i in vetor)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine( );
                    }
                    pos++;
                }
                ultimo = ultimo_temp;
            }
        }
    }
}
