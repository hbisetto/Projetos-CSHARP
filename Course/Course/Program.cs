using System;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100; //sbyte -128 a 127
            byte n1 = 126; //byte de 0 a 255
            int n2 = 1000;
            int n3 = 2147483647; //limite do int
            long n4 = 2147483648L;
            bool completo = false;
            char genero = 'F'; //Entre aspas simples ' ' --  serve também colocando o código unicode do caractere
            char teste = '\u0025'; //% = \u0025 em unicode
            float n5 = 4.5f; //tem que colocar o f após o número quando este for float
            double n6 = 3.5;
            string nome = "Maria Rita"; //string -> aspas duplas " "
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);  
            Console.WriteLine(n3);      
            Console.WriteLine(n4);
            //cw + TAB = Console.WriteLine( );
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(teste);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}
