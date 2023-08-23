namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float bruto = 2000.00f, noturno = 500.00f, extras = 100.00f, descontos = 200.00f, liquido;

            liquido = (bruto + noturno + (extras * 5) - descontos);

            Console.WriteLine($"\n Salario do mes :{liquido:f2}");





             
        }
    }
}