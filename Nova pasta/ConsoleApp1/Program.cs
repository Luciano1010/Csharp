using System.Runtime.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA, numB, numC;
            int soma = 0;



            Console.WriteLine(" Digite um numero: ");
            numA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Digite um numero: ");
            numB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Digite um numero: ");
            numC = Convert.ToInt32(Console.ReadLine());
            // quando eu for fazer um calculo sempre usar os operadores.
            soma = numA + numB;

            if (soma > numC)
            {
                Console.WriteLine($" A soma de {soma} é maior do que a letra: {numC}");
            }
            else
            {
                Console.WriteLine($" A soma de {soma} é menor do que : {numC} ");
            }
        }       
    }
}