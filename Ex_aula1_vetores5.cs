//Exercício 5: Busca em um Vetor Elabore um programa em C# que declare um vetor de strings com nomes predefinidos. Solicite ao usuário um nome para busca. Verifique se o nome está presente no vetor e exiba uma mensagem informando se o nome foi encontrado ou não.

using System;

class Program {
  public static void Main (string[] args) {
    //Declarando vetor de strings com nomes predefinidos
    string[] nomes = {"Henrique", "Helga", "Magda", "Luis", "Thales", "Miguel"};
    string busca;  
    bool num = false;
    
    Console.WriteLine("Digite um nome para busca no vetor:");
    busca = Console.ReadLine();

    for (int i = 0; i < nomes.Length; i++)
    {
      if (nomes[i] == busca)
        {
          Console.WriteLine("Nome encontrado na posição {0}", i);
          num = true;
        }
    }
    if (num == false)
    {
      Console.WriteLine("Nome não encontrado no vetor");
    }
  }
}
