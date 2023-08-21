//Exercício 5: Busca em Matriz  Crie um programa em C# que declare uma matriz retangular (qualquer tamanho) preenchida com números inteiros. Solicite ao usuário um valor para busca. Verifique se o valor está presente na matriz e, se estiver, imprima a posição (linha e coluna) onde o valor foi encontrado.
using System;

class Program {
  public static void Main (string[] args) {
    string[,] matriz = { 
      {"Henrique", "Maria", "Miguel"}, 
      {"Helga", "Magda", "Luis"} 
      };
    
  
    int l = matriz.GetLength(0);
    int c = matriz.GetLength(1);
    
    Console.WriteLine("Extensão da matriz: [{0},{1}]", l, c);
    Console.WriteLine();
    Console.Write("Digite um nome para busca na matriz:");
    string nome = Console.ReadLine();
    bool condicao = false;
    
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
      for (int j = 0; j < matriz.GetLength(1); j++)
      {
        if (matriz[i,j] == nome)
        {
          Console.WriteLine("Nome localizado na posição [{0}, {1}]", i,j);
          condicao = true;
        }
      }
    }

    if (condicao == false)
    {
      Console.WriteLine("Nome não localizado na matriz.");
    }
  }
}
  
