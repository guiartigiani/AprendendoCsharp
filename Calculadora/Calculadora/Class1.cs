using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
   
    public class Calculadora
    {
        double n1, n2;
        double result;
        string resp;
        public double Somar()
        {
            Console.Write("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            result = n1 + n2;
            GetResultado();
            Retorno();
            return result;
        }

        public double Subtracao()
        {
            Console.Write("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = double.Parse(Console.ReadLine());
            result = n1 - n2;
            GetResultado();
            Retorno();
            return result;
        }

        public double Multiplicacao()
        {
            Console.Write("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = double.Parse(Console.ReadLine());
            result = n1 * n2;
            GetResultado();
            Retorno();
            return result;
        }
        public double Divisao()
        {
            Console.Write("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = double.Parse(Console.ReadLine());
            result = n1 / n2;
            GetResultado();
            Retorno();
            return result;

        }

        public double Potencia()
        {
            Console.Write("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            result = Math.Pow(n1, n2);
            GetResultado();
            Retorno();
            return result;
            
        }

        public void Raiz()
        {
            Console.Write("Digite qual numero deseja a Raiz Quadrada: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            result = Math.Sqrt(n1);
            GetResultado();
            Retorno();
        }



        public double GetResultado()
        {
            Console.WriteLine("Seu resultado é:" + result);
            return result;
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha qual operação deseja fazer:" +
                "\n 1- Soma" +
                "\n 2- Subtração" +
                "\n 3- multiplicação" +
                "\n 4- divisão" +
                "\n 5- potência" +
                "\n 6- Raiz Quadrada" +
                "\n 7- Sair");
            string escolha = Console.ReadLine();
            switch (escolha)
            {
                case "1":
                    Somar();
                    break;
                case "2":
                    Subtracao();
                    break;
                case "3":
                    Multiplicacao();
                    break;
                case "4":
                    Divisao();
                    break;
                case "5":
                    Potencia();
                    break;
                case "6":
                    Raiz();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        public void Retorno()
        {
            Console.WriteLine("Deseja realizar outra operação? s/n");
            resp = Console.ReadLine();
            if (resp == "s")
                Menu();
            else if (resp == "n")
                Environment.Exit(0);
            
        }
    }
}