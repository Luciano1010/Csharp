using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float  bruto  , noturno , extras  , descontos , liquido;

            Console.WriteLine("\n adicione o valor do salario bruto: ");
            bruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n adicione o valor do adicional noturno: ");
            noturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n adicione o valor das horas extras: ");
            extras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n adicione o valor dos descontos: ");
            descontos = Convert.ToSingle(Console.ReadLine());



            liquido = (bruto + noturno + (extras * 5) - descontos);

            Console.WriteLine($"\n Salario do mes :{liquido:f2}");

             
        }
    }
}