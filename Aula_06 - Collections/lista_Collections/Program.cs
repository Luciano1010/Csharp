namespace lista_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(6.0);
            notas.Add(10.0);
            
            foreach (double nota in notas) 
            {
                    Console.WriteLine(nota);
            }
            // identificar a posição do indice
            Console.WriteLine("posição da nota 4.0: " + notas.IndexOf(4.0));
            //
            Console.WriteLine("posição da nota 4.0 existe?: " + notas.Contains(4.0));
            
            // deletar elementos
            notas.Remove(4.0);
            // foeach percorre de forma crescente e cada passagem ele adiciona o valor na variavel notas.
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine("posição da nota 10.0: " + notas.IndexOf(10.0));
            // checar o elemento existe
            Console.WriteLine("posições: " + notas.Count);

            // ordenação crescente
            notas.Sort ();
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine();
            
             
            // ordenação decrescente
            notas.Reverse ();

            foreach(double nota in notas)
            {
                Console.WriteLine(nota);
            }

            // como atualizar na collections
            notas[0] = 9.0;

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }



        }
        
    }

}