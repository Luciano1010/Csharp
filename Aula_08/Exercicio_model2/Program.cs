using Exercicio_model2.model2;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using Exercicio_Funcionarios.model2;

namespace Exercicio_model2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Conta2 c1 = new Conta2(29, "123.345.678", "LUCIANO SIMÕES", "GERENTE");
            c1.Visualizar();
            c1.Getnumero("128737367");
            c1.Visualizar();
            c1.Getidade(500);
            c1.Visualizar();*/

            Vendedor c2 = new Vendedor( 29,  "4326", "Luciano Simões", "Vendedor",  "Foto","" );
            c2.Visualizar();

            Gerente c3 = new Gerente(29," 8976" , "luciano", "Gerente", "foto", "230809");
            c3.Visualizar();
        }

    }
}