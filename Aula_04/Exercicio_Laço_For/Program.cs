using System;
using System.ComponentModel.Design;

namespace Exercicio_Laço_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, contador;

            Console.WriteLine("------------------inicio---------------------");

            
            Console.WriteLine("   Digite um numero que seja multiplo de 3: ");
            num1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("   Digite um numero que seja multiplo de 5: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2) // se numero1 for maior que no numero 2 ele pula pra else e finaliza o programa

            {
                for (contador = num1; contador < num2; contador++) // for vai começar a conta aparti do num1 e se o numero num2 for menor o programa e adiciona no contador ++
                {
                    if (contador % 3 == 0 && contador % 5 == 0) // se o resultado nao der zero nao é um multiplo, o programa ele volta for ate chegar no ponto que nesse caso é o numero2.

                        Console.WriteLine($" Esse Número {contador} ele é Multiplo de 3 e 5. ");
                      
                }
            }
            else
                Console.WriteLine("\n Operação Invalida"); // so ira funcionar se a condiçao if nao for verdade.
            Console.WriteLine("--------------------Fim---------------------");


            

        }
    }
}