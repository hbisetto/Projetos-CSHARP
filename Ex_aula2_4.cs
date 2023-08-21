//Exercício 4: Multiplicação de Matrizes Elabore um programa em C# que declare duas matrizes, uma de ordem 2x3 e outra de ordem 3x2. Preencha essas matrizes com valores inteiros de sua escolha. Realize a multiplicação dessas matrizes e imprima a matriz resultante.
using System;
class Program {
    static void Main(string[] args) {
        int[,] matriz1 = { { 2, 3, 4 }, { 5, 6, 7 } };
        int[,] matriz2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        int[,] resultado = new int[matriz1.GetLength(0), matriz2.GetLength(1)];
        
        for (int i = 0; i < matriz1.GetLength(0); i++) {
            for (int j = 0; j < matriz2.GetLength(1); j++) {
                for (int k = 0; k < matriz1.GetLength(1); k++) {
                    resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                }
                Console.Write(resultado[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Matriz1 :");
        for (int i = 0; i < 2; i++)
          {
            for (int j = 0; j < 3; j++)
              {
                Console.Write(" {0} ", matriz1[i,j]);
              }
            Console.WriteLine();
          }
        Console.WriteLine();

        Console.WriteLine("Matriz2 :");
        for (int i = 0; i < 3; i++)
          {
            for (int j = 0; j < 2; j++)
              {
                Console.Write(" {0} ", matriz2[i,j]);
              }
            Console.WriteLine();
          }
        Console.WriteLine();
    }
}
  
