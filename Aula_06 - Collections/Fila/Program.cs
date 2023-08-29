namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Brenno");
            fila.Enqueue("Edu");
            fila.Enqueue("Julia");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Gaspar");
          
            fila.Dequeue();
            
            foreach (var nome in fila) 
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine(" Qual o primeiro da fila: " + fila.Peek());

            // verificar se tal elemento esta na fila
            Console.WriteLine(" O Gaspar entrou na fila?: " + fila.Contains("Gaspar"));

            // pra ver quantas pessoas tem na fila
            Console.WriteLine(" Quanto numeros de pessoas na fila?: " + fila.Count());

        }
    }
}