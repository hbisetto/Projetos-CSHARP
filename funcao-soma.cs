using System;

class Program {
  public static void Main (string[] args) {
    int nn1, nn2;

    Console.Write("Digite o primeiro valor:");
    nn1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor:");
    nn2 = int.Parse(Console.ReadLine());

    

    Console.WriteLine("A soma dos dois valores é: {0}", soma(nn1,nn2));
  }

  //void = vazio; int = inteiro (porque o que vai ser "devolvido" pela função é um valor inteiro)
  public static int soma (int n1, int n2){
    int s;

    s = n1 + n2;

    return s;
    
  }
}
