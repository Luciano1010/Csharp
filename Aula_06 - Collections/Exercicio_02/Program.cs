namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
                HashSet<int> numero = new HashSet<int>();
                        
                for(int contador =0; contador < 10; contador++)
                {
                    Console.WriteLine(" Digite um Numero: ");
                    numero.Add(Convert.ToInt32(Console.ReadLine()));
                }

            Console.WriteLine("=================================");
                foreach(int contador in numero) 
                {
                    Console.WriteLine($" liste os dados:{contador}");
            
                }   
            
        
        }
    }
}