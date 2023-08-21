//Exercício 3: Transposta de Matriz. Crie um programa em C# que declare uma matriz retangular (qualquer tamanho) e calcule sua matriz transposta. A matriz transposta é obtida trocando as linhas pelas colunas da matriz original. Imprima a matriz transposta resultante.
using System;

class Program {
  public static void Main (string[] args) {
    int[,] matriz1 = new int[3,4];

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 4; j++)
      {
        matriz1[i,j] = i * j;
      }
    }

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 4; j++)
      {
        Console.Write(" {0} ", matriz1[i,j]);
      }
      Console.WriteLine();
    }

    int[,] matriz2 = new int[4,3];

    for (int i = 0; i < 4; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        matriz2[i,j] = matriz1[j,i];
      }
    }

    Console.WriteLine();
    
    for (int i = 0; i < 4; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        Console.Write(" {0} ", matriz2[i,j]);
      }
      Console.WriteLine();
    }
    
  }
}
