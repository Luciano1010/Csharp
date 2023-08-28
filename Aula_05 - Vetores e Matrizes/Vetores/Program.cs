namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {   // como funciona e como percorre um vertor... conceito de vetor
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] vetor02 = new int[5];

            for (int indice = 0; indice < 10; indice++)
            {
                Console.WriteLine($"vetor01[{indice}]) = {vetor01[indice]}");
            }
            Console.WriteLine("\n");

            // propriedade lenght ele serve pra percorrer o vetor sem necessidade de 
            // especificar o tamanho - ele ja identifica o tamanho maximo do vetor

            Array.Sort(vetor02); // metedo de ordenar os elementos em ordem crescente
            for (int indice = 0; indice < vetor02.Length; indice++)
            {
                Console.Write($"vetor02[{vetor02}]) = ");
                vetor02[indice] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (int indice = 0; indice < 5; indice++)
            {
                Console.WriteLine($"vetor02[{indice}] = {vetor02[indice]}");

            }

            Console.WriteLine("\n");    
            Array.Reverse(vetor02); // metedo de ordenar os elementos em ordem decrescente
            for (int indice = 0; indice < vetor02.Length; indice++)
            {
                Console.Write($"vetor01[{vetor02}]) = ");
                vetor02[indice] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (int indice = 0; indice < 5; indice++)
            {
                Console.WriteLine($"vetor02[{indice}] = {vetor02[indice]}");

            }

            Console.WriteLine(Array.IndexOf(vetor02, 5));

            // como trazer numero pares usando vetor
            for (int indice = 0; indice < vetor01.Length; indice++)
            {
                if (vetor01[indice] %2 ==0) 
                {
                    Console.WriteLine($"vetor01[{indice}] = {vetor01[indice]}");  
                }
            }
        }


    }
}