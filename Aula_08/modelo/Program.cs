using modelo.exercicio_model;

namespace modelo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Conta c1 = new Conta(29, 407906 , "Rua X", "Luciano", "luciano_x");
            c1.Visualizar();
            c1.getendereco();
            c1.Visualizar();
            c1.setidade(123);
            c1.Visualizar();



        }
    }
}