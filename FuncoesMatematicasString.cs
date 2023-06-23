using System;

class Program {
  public static void Main (string[] args) {
    // Funções Matemáticas
    Console.Write("O número Pi é igual a ");
    Console.WriteLine(Math.PI); //função do número PI

    Console.WriteLine();
    
    double  total;
    total = Math.Pow(4,3); //Função de potência
    Console.Write("4 elevado a 3 é igual a ");
    Console.WriteLine(total);

    Console.WriteLine();
    
    total = Math.Sqrt(81); // função de raiz quadrada
    Console.Write("A raiz quadrada de 81 é: ");
    Console.WriteLine(total);

    Console.WriteLine();
    //Fim das funções matemáticas

    //Funções String
    Console.WriteLine("Aqui começam as aplicações das funções em string");
    String texto;

    texto = "EsTe É mEU TeXTO OrigiNAL.";
    
    texto = texto.ToUpper();
    Console.WriteLine(texto);
    texto = texto.ToLower();
    Console.WriteLine(texto);
  }
}