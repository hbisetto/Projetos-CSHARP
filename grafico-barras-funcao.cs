using System;

class Program {
  public static void Main (string[] args) {
    //GraficoBarras(3,4,5);
    Console.WriteLine(" GRAFICO DE BARRAS ");
    Console.Write("Digite o primeiro valor:");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo valor: ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Digite o terceiro numero:");
    int c = int.Parse(Console.ReadLine());

    GraficoBarras(a,b,c); //Chama a função abaixo com os valores coletados acima
  }

  public static void GraficoBarras (int n1, int n2, int n3){
    int i;

    for (i=0; i < n1;i++){
      Console.Write("#");
    }
    Console.WriteLine(" " + n1);

    for (i=0; i < n2; i++){
      Console.Write("#");      
    }
    Console.WriteLine(" " + n2);

    for (i=0; i < n3; i++){
      Console.Write("#");    
    }
    Console.WriteLine(" "+n3);
  }
}
