namespace Do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero , resultado = 0;

            do // qual a condição de parada
            { // apos a verificação da condição ele entra dentro dos colchetes
                Console.WriteLine(" Digite um numero: "); 
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0) // se eu adicionar um numero negativo ele ignora e repete o processo ate que o zero seja digitado
                resultado += (numero);


            } while (numero != 0); // aqui mostra a condição de parada "do while"

            Console.WriteLine($" a soma dos numeros inteiros é {resultado}");
        }
    }
}