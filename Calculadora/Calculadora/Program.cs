using System;
namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            int valor2 = int.Parse(Console.ReadLine());
           
            Calculo operacao = new Calculo();
            operacao.escolha();
            
            
        }
    }
}
