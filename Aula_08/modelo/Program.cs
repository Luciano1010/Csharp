using modelo.exercicio_model;
 
namespace modelo
{
    public class Program
    {
        static void Main(string[] args)
        {

           /* Conta c1 = new Conta(" 1234567 ", 407906 , "Rua X", "Luciano", "luciano_x", 03);
            c1.Visualizar();
            c1.getendereco();
            c1.Visualizar();
            c1.setid(123);
            c1.Visualizar();*/

            /*PessoaFisica c2 = new  PessoaFisica(" 1234567 ", 407906, "Rua X", "kujs"," luicnoa",10, "12332344");
            c2.Visualizar();*/
            Pessoajuridica c3 = new Pessoajuridica(" (11) 97645-9076 ", 03, "Rua X", "Luciano", " luciano_lopesdealmeida@hotail.com", "Conta tipo Empresa","431.543.212-0", "21.987.453/0001-70");
            c3.Visualizar();
            
        }
    }
}