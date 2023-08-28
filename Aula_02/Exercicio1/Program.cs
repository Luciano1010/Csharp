namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, resultado;

            
            Console.WriteLine("\n------------inicio-------------\n");
            
            Console.WriteLine("\n Digite o valor do seu salario: ");
            salario =Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n Digite o valor do abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n------------Aguarde......\n");

            resultado = salario + abono;

            Console.WriteLine(" \n O seu salario é de " + resultado);



        }
    }
}