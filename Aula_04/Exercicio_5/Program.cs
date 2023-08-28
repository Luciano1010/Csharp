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

                if (num % 2 == 0 && num > 0)
                {
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

















                    
                























