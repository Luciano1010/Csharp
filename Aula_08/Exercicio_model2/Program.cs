using Exercicio_model2.model2;

namespace Exercicio_model2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta2 c1 = new Conta2(29, "123.345.678", 456123, "LUCIANO SIMÕES", "GERENTE");
            c1.Visualizar();
            c1.setnumero(678123);
            c1.Visualizar();
            c1.setidade(210);
            c1.Visualizar();

        }
    }
}