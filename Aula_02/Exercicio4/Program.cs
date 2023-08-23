namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1 = 5.0f, n2 = 6.0f, n3 = 7.0f, n4 = 8.0f, calculo;

            calculo = (n1 * n2) - (n3 * n4);

            Console.WriteLine($"\n o resultado do primeiro exemplo :{calculo:f2}");

            n1 = 5.0f; n2 = 6.0f; n3 = -7.0f; n4 = 8.0f; calculo = 0;

            calculo = (n1 * n2) - (n3 * n4);

            Console.WriteLine($"\n o resultado do segundo exemplo : {calculo:f2}" );


        }
    }
}