namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, soma;

            Console.WriteLine(" entre com o numero da letra (A): ");
            num1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine(" entre com o numero da letra (B): ");
            num2 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine(" entre com o numero da letra (C): ");
            num3 = Convert.ToInt32(Console.ReadLine());
            
            soma = (num1 + num2);
        
            if (soma < num3)
            {
                Console.WriteLine("  a soma de A + B é menor do que numero da letra (C)");
            }

        }
                
    }

}




           

            


