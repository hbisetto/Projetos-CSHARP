using System;

class Program {
 
  public int multiplicar(int x, int y){
  int total;
  total = x * y;
  return total;
  } 

  
  public static void Main (string[] args) {
    Program calculadora = new Program();
    //Calcular a área do quadrado
    int lado = 10;
    int areaQuadrado = calculadora.multiplicar(lado, lado);
    Console.WriteLine("A área do quadrado é igual a: " +areaQuadrado);

    //Calcular a área do triângulo
    int b = 5;
    int altura = 5;
    int areaTriangulo = calculadora.multiplicar(b,altura)/2;
    Console.WriteLine("A área do triângulo é igual a: " + areaTriangulo);
    
  }
}
