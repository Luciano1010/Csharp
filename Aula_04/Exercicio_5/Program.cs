using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,par = 0, impar = 0,contador;

            for ( contador = 0; contador < 10; contador ++)
            {

                Console.WriteLine(" Digite um numero:");
                num = Convert.ToInt32(Console.ReadLine());
                // usei o if pra especificar o quero q conte q no caso é os numeros par.
                if (num % 2 == 0 && num > 0)
                {  // quando eu precisar contar algo ou juntar uso o ++
                    par++;
                   
                }
                else if (num % 2 != 0 && num > 0)
                {
                    impar++;
                }

            }
                    
                Console.WriteLine($" numero par {par}");
                Console.WriteLine($" numero impar{impar} ");
                    
        }

    }
               
}




















                    
                























