using System;

namespace OrientacaoObjetos1
{
    internal class Triangulo
    {
        public double A; //Definindo o atributo dos lados do triângulo. O nome do atributo vem em letra maiúscula
        public double B;
        public double C;

        //Criando um método, ou seja, uma função dentro de uma classe
        public double Area()
        { //Funções começam com letra maiúscula em C#
            double p = (A + B + C) / 2.0; //A, B, C do triangulo em questão
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //ou seja, já retorna o rezuad
        }
    }
}