//Exercício 2: Média de Valores em um Vetor Escreva um programa em C# que declare um vetor de inteiros com valores predefinidos. Calcule a média dos valores contidos no vetor e imprima o resultado na tela.
using System;

class Program {
  public static void Main (string[] args) {
    int[] vetores = {5, 6, 7, 8, 9, 10};
    double media;
    int soma;

    soma = 0;
    media = 0;
    
    for(int i = 0; i < vetores.Length; i++)
    {
      soma = soma + vetores[i];
    }
    media = Convert.ToDouble(soma) / vetores.Length;
    Console.WriteLine("Média dos valores do vetor = {0}", media);
  }
}
