using System;

class Program {
  public static void Main (string[] args) {
    double[] notas = {7.8, 6.5, 5.6};

    double soma = 0;
    for (int i = 0; i < notas.Length; i++){ //o .Length indica o tamanho do vetor
      soma += notas[i];
      }
    double media = soma / notas.Length;
    Console.WriteLine("SOMA = " + soma);
    Console.WriteLine("MEDIA = " + media);
  }
}
