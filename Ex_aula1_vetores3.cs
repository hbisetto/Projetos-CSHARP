//Exercício 3: Maior Valor em um Vetor Desenvolva um programa em C# que declare um vetor de inteiros com valores predefinidos. Encontre e imprima o maior valor presente no vetor.
using System;

class Program {
  public static void Main (string[] args) {
    int[] vetorx = {3, 6, 7, 123, 23, 4, -5};
    for (int i = 0; i < vetorx.Length; i++)
    {
      Console.WriteLine("Posição {0}, valor = {1}", i, vetorx[i]);
    }
    int maior;
    maior = -6;
    
    for (int i = 0; i < vetorx.Length; i++)
    {
      if (vetorx[i] > maior)
      {
        maior = vetorx[i];
      }
    }
    
    Console.WriteLine("Maior valor de vetor = {0}", maior);
  }
}
