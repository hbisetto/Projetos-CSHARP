//Exercício 1: Soma de Matrizes Crie um programa em C# que declare duas matrizes quadradas de ordem 3x3. Preencha essas matrizes com valores inteiros de sua escolha. Em seguida, crie uma terceira matriz que armazene a soma dos elementos correspondentes das duas matrizes anteriores. Imprima a matriz resultante.
using System;

class Program {
  public static void Main (string[] args) {
    //Criação de duas matrizes [3,3]
    int[,] matriz1 = new int[3,3];
    int[,] matriz2 = new int[3,3];
    
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        matriz1[i,j] = i + j;
      }
    }

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        matriz2[i,j] = i + j;
      }
    }

    //Criação de uma terceira matriz
    int[,] matrizsoma = new int[3,3];
    
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        matrizsoma[i,j] = matriz1[i,j] + matriz2[i,j];
      }
    }

    Console.WriteLine("Soma dos elementos das matrizes");
    Console.WriteLine();

    Console.WriteLine("Matriz 1:");
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        Console.WriteLine("Matriz [{0},{1}] = {2}", i, j, matriz1[i,j]);
      }
    }
    Console.WriteLine();
    
    Console.WriteLine("Matriz 2:");
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        Console.WriteLine("Matriz [{0},{1}] = {2}", i, j, matriz2[i,j]);
      }
    }
    Console.WriteLine();
    
    Console.WriteLine("Soma das matrizes:");
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        Console.WriteLine("Matriz [{0},{1}] = {2}", i, j, matrizsoma[i,j]);
      }
    }
    
  }
}
