using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        private const double V = 1000.50;

        static void Main(string[] args)
        {
            Console.WriteLine("Executando proejeto 3 - Criando Variáveis com ponto flutuante");

            double salario;
            salario = 1.55184f;

            Console.WriteLine(salario);

            Console.WriteLine("Programa Finalizado, para sair aperte ENTER...");
            Console.ReadLine();
        }
    }
}
