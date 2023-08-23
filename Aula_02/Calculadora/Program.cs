namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, divisao;
            Console.WriteLine("Digite o Primero numero:");
            numero1 = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Digite o Segundo numero:");
            numero2 = Convert.ToSingle(Console.ReadLine());

            divisao = numero1 / numero2;

            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));
            Console.WriteLine($"{numero1} / {numero2} = {2:F} ", (numero1 / numero2));

            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero1, numero2));

            Console.WriteLine($"Raiz quadrada de {numero1} ^ {numero2} = " + Math.Sqrt(numero1));

        }
    }
}