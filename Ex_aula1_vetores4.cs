//Exercício 4: Contagem de Pares e Ímpares Crie um programa em C# que declare um vetor de inteiros com valores predefinidos. Contabilize e imprima a quantidade de números pares e ímpares presentes no vetor.
using System;

class Program {
  public static void Main (string[] args) {
    //Criação de vetor de inteiros com valores predefinidos.
    int[] vetor = {5, 6, 7, 12, 56, 32, 7};

    //Vetores e suas posições
    for (int i = 0; i < vetor.Length; i++)
    {
      Console.WriteLine("Vetor na posição {0} = {1}", i, vetor[i]);
    }

    //Contagem de vetores pares e ímpares
    int pares, impares;
    pares = 0;
    impares = 0;
    for (int i = 0; i < vetor.Length; i++)
    {
      if (vetor[i] % 2 == 0 )
        {
          pares = pares + 1;
        }
      else 
        {
          impares = impares + 1;
        }
    }

    Console.WriteLine("Quantidade de elementos pares no vetor = {0}", pares);
    Console.WriteLine("Quantidade de elementos impares no vetor = {0}", impares);
  }
}
