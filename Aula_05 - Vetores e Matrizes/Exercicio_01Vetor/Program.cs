namespace Exercicio_01Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int compara = 0;
            bool elemento = false;// para declaração de if/else
            

            Console.WriteLine(" Digite um numero para saber a posiçao:");
            compara = Convert.ToInt32(Console.ReadLine());

            for (int indice = 0; indice < 10; indice++)
            {
                if (compara == vetor1[indice] )
                {                                         // busca posição dentro do vetor
                    Console.WriteLine("Elemento na posição : " + Array.IndexOf(vetor1, compara) + " " + compara);
                    elemento = true;
                    break;
                    
                }

            }
                if (elemento == false)
                {
                    Console.WriteLine(" numero não encontrado ");
                }
                
        }

    }

}
                

































    
        