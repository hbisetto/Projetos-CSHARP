using System;


class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Defina quantos alunos há na turma:");
  int tamanho = int.Parse(Console.ReadLine());
  double[] notas = new double[tamanho];
  //Armazenando as notas
  for (int i = 0; i < notas.Length; i++) {
  Console.WriteLine("Digite a nota do aluno " + (i + 1) +
  ":");
  notas[i] = double.Parse(Console.ReadLine());
  }
  //Recuperando as notas para calcular a média
  double soma = 0;
  for (int i = 0; i < notas.Length; i++) {
  Console.WriteLine("Nota do aluno " + (i + 1) +
  ": "+notas[i]);
  soma += notas[i];
  }
  double media = soma / notas.Length;
  Console.WriteLine("Média das notas na turma é: "+media.ToString("F2"));  //.ToString("F2") = duas casas decimais
  }
  
}
