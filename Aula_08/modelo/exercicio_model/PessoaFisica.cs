using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.exercicio_model
{
    public class PessoaFisica : Conta
    {
            private string cpf;

        public PessoaFisica(string telefone, int id, string endereco, string nome, string email, string tipo,string cpf) : base(telefone, id, endereco, nome, email, tipo)
        {
            this.cpf = cpf;
        
        }

        public string Getcpf()
        {
            return cpf;
        }



        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine(" CPF do titular da Conta: " + this.cpf);
        }
    }

       





   







}
