using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_model2.model2
{
    public class Vendedor : Funcionario
    {
        
        private string vender;

        public Vendedor(int idade, string numero, string nome, string cargo,string foto, string vender) : base(idade, numero, nome, cargo, foto)
        {
            this.vender = vender;
        }

        public string Getvender()
        {
            return vender;
        }


        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("sua funcão é Vendedor" + this.vender);
        }
    }
}
