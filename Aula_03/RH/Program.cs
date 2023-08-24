namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int cargo;
            float salario, reajuste;


            Console.WriteLine(" Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine(" Digite seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" Digite seu salario: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 7) / 100;
                    break;
                case 2:
                    reajuste = (salario * 9) / 100;
                    break;
                case 3:
                    reajuste = (salario * 5) / 100;
                    break;
                 default:
                  reajuste = (salario * 12) / 100;
                  break; 
            
            }

            

            Console.WriteLine($" o reajuste de salario  do (a) {nome} é de: {reajuste}");
            Console.WriteLine($" O novo salario do (a) é de:{salario}");

            

            

            
                
            

               

        }
                








    }
}