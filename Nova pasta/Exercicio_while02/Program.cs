using System.ComponentModel.Design;

namespace Exercicio_while02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeMe = 0, idadeMa;
           
            while ( idadeMe < 0)
            {
                Console.WriteLine(" Digite sua Idade: ");
                idadeMe = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Digite Sua idade:  ");
                idadeMa = Convert.ToInt32(Console.ReadLine());

                for (int contador = 1;   contador < idadeMe; contador ++)
                {
                    if (idadeMe > 0 && idadeMe < 21)
                        idadeMe++;
                    else if (idadeMe > 0 && idadeMe > 50) ;
                    idadeMe++;
                
                }
                    
                
                
            }







        


        
           
            




        }
    }
}