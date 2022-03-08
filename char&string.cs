using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresEtextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            /* tipo char guarda apenas um caractere da tabela ascii. 
            Por isso, quando passamos um valor numérico, teremos como saída o caractere correspondente ao número na tabela ascii*/
            
            Console.WriteLine(primeiraLetra);
            /*O 65 apesar de um numero intiero, quando eu converto ele para char, ele vai me puxar o codigo que ele representa
            nesse caso, quando eu rodar esse programa o numero 65 será representado pela letra "A", é importante
            lembrar que é a letra é maiuscula.*/

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);
            /*Quando eu coloco o "char" eu estou converventendo todo o conteudo seguinte naquele tipo de dado,
            então nesse caso ele vai pegar o valor da variavel que está como 65 e somar + 1 que no caso vai me
            apresentar outro valor.
            Diferente do char, o tipo string aceita apenas texto, ele é caracterizado pelas aspas duplas, no caso do char
            é aspas simples*/

            char testeVazio = ' ';
            Console.WriteLine(testeVazio);
            //No tipo char não podemos deixar um espaço vazio, ele precisa ter um caractere pelo menos, nem que seja um espaço
            string StringVazia = "";
            Console.WriteLine(StringVazia);
            //No caso da string eu posso enviar um comando sem nada, sem nenhum caractere dentro pois o C# aceita.

            string titulo = "Alura Cursos de tecnologia " + 2020;
            string cursosProgramacao = 
@"- .NET
- Java
- Javascript"; 
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            /*No momento em que usamos @, o compilador vai considerar tudo entre as aspas e o texto, 
            inclusive o espaço. Para solucionar, posso remover os espaços entre os cursos, como no exemplo acima.*/

            Console.WriteLine("Execução Finalizada, aperte ENTER para sair...");
            Console.ReadLine();
        }
    }
}
