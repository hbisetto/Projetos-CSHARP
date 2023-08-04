using System;

class Program {
  public static void Main (string[] args) {
    double[] notas = {5.5, 7.6, 8.5};
    double media = (notas[0] + notas[1] + notas[2]) / 3;

    double soma = 0;
    for (int i = 0; i < 3; i++){
      soma += notas[i];      
    }

    double media2 = soma / 3;
    Console.WriteLine("          NOTAS          ");
    for (int j = 0; j < 3; j++){
      Console.WriteLine("Posição do vetor " + j + " = " + notas[j]);
    }
    Console.WriteLine("Média = " + media2);
    Console.WriteLine("Soma = " + soma);
  }
}
