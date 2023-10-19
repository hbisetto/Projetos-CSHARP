using System;
using System.Collections.Generic;
using System.Text;

namespace Tad
{

    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double Liquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porc)
        {
            Salario = Salario + (Salario * (porc/100));
        }
    }
}

