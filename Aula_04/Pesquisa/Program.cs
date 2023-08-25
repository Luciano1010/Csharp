namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, continua = "S";
            int idade, esporte, futebol = 0, voleiM18 = 0, basqueteMenor18 = 0;

            do 
            {
                Console.WriteLine(" Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine(" Digite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine(" Digite o seu Esporte favorito (1-fut/2-Volei/3-Basq/4-Outro: ");
                    esporte = Convert.ToInt32(Console.ReadLine());
                } while (esporte < 1 || esporte > 4);
                    
                if (esporte == 1) 
                {
                    futebol++;
                }
                    
                    Console.WriteLine(" Deseja Continuar (S/N):");
                    continua = Console.ReadLine().ToUpper();
                

                
                
            } while(continua.Equals("S"));


                   

        }
    }
}