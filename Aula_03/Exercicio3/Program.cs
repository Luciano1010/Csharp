namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("\n--------------------------\n");

            Console.WriteLine(" --> Digite um numero Par ou Impar <--:  ");
            numero1 = Convert.ToInt32(Console.ReadLine());


            if (numero1 % 2 == 0 && numero1 < 0)
            {
                Console.WriteLine($" O numero: {numero1} é par negativo: ");
            }
            else if (numero1 % 2 == 0 && numero1 > 0)
            {
                Console.WriteLine($" o numero {numero1} é par positivo");
            }
            else if (numero1 % 2 != 0 && numero1 > 0)
            {
                Console.WriteLine($" o numero {numero1} é impar positivo");
            }

            else if (numero1 % 2 != 0 && numero1 < 0)
            {
                Console.WriteLine($" o numero {numero1} é impar negativo");
            }
            else
            {
                Console.WriteLine(" numero invalido ");
             }
            

        }
    }
}




