namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4;
            float soma ;
           
            Console.WriteLine(" digite a primeira nota:");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" digite a primeira nota:");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" digite a primeira nota:");
            n3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" digite a primeira nota:");
            n4 = Convert.ToSingle(Console.ReadLine());

            soma = (n1 * n2) - (n3 * n4);

            Console.WriteLine("=============================");

            Console.WriteLine($" a diferenca de {soma:F1} ");

            Console.WriteLine(" digite a primeira nota:");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" digite a primeira nota:");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" digite a primeira nota:");
            n3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" digite a primeira nota:");
            n4 = Convert.ToSingle(Console.ReadLine());

            soma = (n1 * n2) - (n3 * n4);
            Console.WriteLine($" a diferenca de {soma:F1} ");

        }
    }
           
}