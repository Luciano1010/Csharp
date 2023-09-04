using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.exercicio_model
{
    public class Pessoajuridica : PessoaFisica
    {


        private string cnpj;

        public Pessoajuridica(string telefone, int id, string endereco, string nome, string email, 
            string tipo, string cpf, string cnpj) : base(telefone, id, endereco, nome, email, tipo, cpf)
        {
            this.cnpj = cnpj;
        }

        public string Getcnpj() 
        {
            return cnpj;
        
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine(" Cnpj Cadastrado : " + this.cnpj);
        }

    }
}
