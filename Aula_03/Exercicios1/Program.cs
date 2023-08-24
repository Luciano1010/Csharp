namespace Exercicios1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroA, numeroB, numeroC, soma, resultado;

            Console.WriteLine("\n=================================\n");

            Console.WriteLine(" Digite o numero da letra A: ");
            numeroA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(" Digite o numero da letra B: ");
            numeroB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Digite o numero da letra C: ");
            numeroC = Convert.ToInt32(Console.ReadLine());

            soma = numeroA + numeroB;

            if (soma > numeroC)
                Console.WriteLine($"\n O resultado da  soma de A + B é maior que a letra C: {numeroC} ");

            else if (soma == numeroC)
            {
                Console.WriteLine($"\n O resultado da  soma de A + B é igual que a letra C: { numeroC}");
                
            }
            
             

                              


        }


    }
}