namespace PlanodeSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade;

            Console.WriteLine(" Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine(" Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine ());

            if (idade > 0 && idade <= 10)
            {
                Console.WriteLine(" A mensalidade é de 100,00 reais");
            }

            else if (idade >= 11 && idade <= 29)
            {
                Console.WriteLine(" A Mensalidade é de de 200,00 reais");
            }
            else if (idade >= 30 && idade <= 45)
            {
                Console.WriteLine(" A Mensalidade é de de 300,00 reais");
            }
            else if (idade >= 46 && idade <= 59)
            {
                Console.WriteLine(" A Mensalidade é de de 500,00 reais");
            }

            else if (idade >= 60 && idade <= 65)
            {
                Console.WriteLine(" A Mensalidade é de de 1000,00 reais");
            }
            else
            {
                Console.WriteLine(" A mensalidade do plano é de 1000,00");
            }
            








            }
        }
}