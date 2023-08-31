using Metodos_02.Namespace01;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero, numero2, divisao;

            Console.WriteLine("Digite o primeiro número:");
            numero = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToSingle(Console.ReadLine());

           

            Console.WriteLine($"{numero} + {numero2} = " + Somar(numero, numero2));
            Console.WriteLine($"{numero} - {numero2} = " + Subtrair(numero , numero2));
            Console.WriteLine($"{numero} * {numero2} = " + Multiplicação(numero , numero2));
            Console.WriteLine(divisao ==0 ? " nao existe divisão por zero:"
            Console.WriteLine($"{numero} + {numero2} = " + Potencia(numero, numero2));
            Console.WriteLine($"Raiz Quadrada de {numero} = " + Raiz(numero));
            Dev();

            Class02cs.MetodoPublico();      
            
        }

        static float Somar(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        static float Subtrair(float numero1, float numero2)
        {
            return numero1 - numero2;
        }

        static float Multiplicação(float numero1, float numero2)
        {
            return numero1 * numero2;
        }

        static float Dividir(float numero1, float numero2)
        {
            if (numero2 > 0)
                return numero1 / numero2;
            else
                return 0;
        }
        static Double Potencia(float numero1, float numero2)
        {
            return Math.Pow(numero1,numero2);
        }

        static double Raiz(float numero1)
        {
            return Math.Sqrt(numero1) ;
        }
    
        static void Dev()
        {
            Console.WriteLine(" Criado por Luciano ");
        }
    
    }
}