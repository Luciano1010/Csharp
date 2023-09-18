using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public class Medicamento : Produto
    {

        private string Generico {get;set;} = string.Empty;
        public Medicamento(int id, string nome, int tipo, decimal preço, string Generico) : base(id, nome, tipo, preço)
        {
            this.Generico = Generico;
        }


        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Nome Generico" + Generico);
        }
    }
}
