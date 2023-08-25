namespace Exercicio_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 1, contagem21 = 0, contagem50 = 0;

            while (idade >= 0) // while ele repete ate condiçao ser valida //
            {
                Console.WriteLine(" Digite sua idade:");
                idade = Convert.ToInt32(Console.ReadLine());

                
                   if (idade <= 21 && idade > 0) // serve pra verificar se a idade esta entre 0 a 21//
                       contagem21++; // esse serve pra adicionar a pessoa na lista de menor de 21 //
                
                   else if(idade >= 50 && idade >0)// a idade digitida foi maior que 50 //
                       contagem50++;// adiciona a pessoa na lista //
            }
            Console.WriteLine($" O Total de pessoa com Idade de 21 anos foi: {contagem21} \n O Total de pessoas com idade acima de 50 foi: {contagem50}");

               
              

        }
    }
}