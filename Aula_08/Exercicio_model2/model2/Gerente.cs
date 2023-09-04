using Exercicio_model2.model2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Funcionarios.model2
{
    public class Gerente : Funcionario
    {

        private string senha;
        public Gerente(int idade, string numero, string nome, string cargo, string foto, string senha) : base(idade, numero, nome, cargo, foto)
        {
        
                this.senha = senha;
        }
        public string Getsenha()
        {
            return senha;
        }


        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Sua Senha de Acesso:" + this.senha);
        }

    }
}
