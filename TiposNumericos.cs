using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversãoEoutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Executando projeto 4- Conversão e outros tipos numéricos");

            double salario;
            salario = 1500.50;

            int salarioEminteiro;
            salarioEminteiro = (int)salario;
            
            Console.WriteLine(salarioEminteiro);

            Console.WriteLine("Projeto Finalizado, Aperte ENTER para finalizar...");
            Console.ReadLine();

        }
    }
}
