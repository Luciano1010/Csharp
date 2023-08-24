namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float salario, reajuste = 0;
            int cargo;

            Console.WriteLine("----Quadro de Funcionarios----");
            

            Console.WriteLine("Opção 1 Gerente");
            Console.WriteLine("Opção 2 Vendedor");
            Console.WriteLine("Opção 3 Supervisor");
            Console.WriteLine("Opção 4 Motorista");
            Console.WriteLine("Opção 5 Estoquista");
            Console.WriteLine("Opção 6 Tecnico de T.I");


            Console.WriteLine("\n Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("\n Digite seu cargo:");
            cargo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Digite seu Salario: ");
            salario = Convert.ToSingle(Console.ReadLine());


            switch (cargo)
            {

                case 1:
                    Console.WriteLine("\n Cargo: Gerente ");
                    reajuste = salario * 0.1F;
                    break;

                case 2:
                    Console.WriteLine("\n Cargo: Vendedor ");
                    reajuste = salario * 0.07F;
                    break;

                case 3:
                    Console.WriteLine("\n Cargo: Supervisor ");
                    reajuste = salario * 0.09F;
                    break;

                case 4:
                    Console.WriteLine("\n Cargo: Motorista");
                    reajuste = salario * 0.06F;
                    break;

                case 5:
                    Console.WriteLine("\n Cargo: Estoquista ");
                    reajuste = salario * 0.05F;
                    break;

                case 6:
                    Console.WriteLine("\n Cargo: Tecnico de T.I ");
                    reajuste = salario * 0.08F;
                    break;

                default:
                    Console.WriteLine("\n Cargo: Opção Invalida ");
                    break;

            }

                Console.WriteLine($" Seu novo salario com o reajuste é de R$ {salario + reajuste:F2} ");


        }

    }

}





  