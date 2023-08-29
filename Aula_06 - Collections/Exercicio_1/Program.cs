namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> cores = new List<string>();
           
            for(int contador = 0; contador < 5; contador ++) 
            {
                Console.WriteLine(" digite uma cor: ");
                cores.Add(Console.ReadLine());
            }

            foreach (var contador in cores) 
            {
                    Console.WriteLine($" lista de todas as cores:{contador}\n");
            }

            Console.WriteLine("=======================================\n");
            cores.Sort();


            foreach(var contador in cores)
            {
                Console.WriteLine($" lista de todas as cores:{contador}");
            }












        }
    }
}