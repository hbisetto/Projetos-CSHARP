//Exercício 2: Matriz Identidade Desenvolva um programa em C# que crie uma matriz identidade de ordem 4x4. Uma matriz identidade é uma matriz quadrada onde os elementos da diagonal principal são 1 e os demais elementos são 0. Imprima a matriz resultante.

using System;

class Program {
  public static void Main (string[] args) {
    int[,] matriz = new int[4,4];

    //Preenchendo a matriz
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        if (i == j)
        {
          matriz[i,j] = 1;
        }
        else 
        {
          matriz[i,j] = 0;
        }
      }
    }

    //Imprimindo a matriz
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        Console.Write(" {0} ", matriz[i,j]);
      }
      Console.WriteLine();
    }
  }
}
