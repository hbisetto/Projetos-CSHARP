////Exercício 1: Soma de Vetores Crie um programa em C# que declare dois vetores de inteiros com o mesmo tamanho (5 elementos). Preencha os vetores com valores inteiros de sua escolha. Em seguida, crie um terceiro vetor que armazene a soma dos elementos correspondentes dos dois vetores anteriores. Imprima o vetor resultante.
using System;

class Program {
  public static void Main (string[] args) {
    int[] vetor1 = new int[5];
    int[] vetor2 = new int[5];

    for (int i = 0; i < vetor1.Length; i++)
    {
      vetor1[i] = i + 1;
      vetor2[i] = i + 2;
    }

    int[] vetorSoma = new int[5];
    for (int i = 0; i < vetorSoma.Length; i++)
    {
      vetorSoma[i] = vetor1[i] + vetor2[i];
    }

    Console.WriteLine("Vetores1:");
    for (int i = 0; i < vetor1.Length; i++)
    {
      Console.WriteLine(vetor1[i]);
    }
    Console.WriteLine();
    
    Console.WriteLine("Vetores2:");
    for (int i = 0; i < vetor2.Length; i++)
    {
      Console.WriteLine(vetor2[i]);
    }
    Console.WriteLine();
    
    Console.WriteLine("Vetores Soma:");
    for (int i = 0; i < vetorSoma.Length; i++)
    {
      Console.WriteLine(vetorSoma[i]);
    }
  }
  
}
