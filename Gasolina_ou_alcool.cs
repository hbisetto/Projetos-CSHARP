using System;

class Program {
  public static void Main (string[] args) {
    double alcool, gasolina, relacao;
    String resposta;

    resposta = "S";

    while(resposta == "S"){
      Console.WriteLine ("Cálculo para ver custo/benefício do combustível.");
      Console.WriteLine("Digite, por favor, o preço do álcool:");
      alcool = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite, por favor, o preço da gasolina:");
      gasolina = double.Parse(Console.ReadLine());
  
      relacao = alcool/gasolina;
  
      if(relacao > 0.7){
        Console.WriteLine("Vale a pena abastecer com gasolina.");
      }
      else if(relacao < 0.7){
        Console.WriteLine("Vale a pena abastecer com álcool.");
      }
      else{
        Console.WriteLine("Tanto faz abastecer com um ou com outro.");  
      }
      Console.WriteLine("O usuário deseja realizar um novo cálculo? [S/N]");
      resposta = Console.ReadLine();
    }
    Console.WriteLine("Fim do programa.");
  }
}