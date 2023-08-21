using System;

class Program {
  public static void Main (string[] args) {
    double[] notas = { 8.7, 5.4, 6.2 };
    double media = calcularMedia(notas);
    Console.WriteLine("A média da turma é: "+media.ToString("F2"));  
  }

  public static double calcularMedia(double[] notas){
    double soma = 0;
    for (int i = 0; i < notas.Length; i++)
    {
      soma += notas[i];
    }
    return soma / notas.Length;
  }
}
