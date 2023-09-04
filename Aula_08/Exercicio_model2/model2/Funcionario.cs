using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_model2.model2
{
    public class Funcionario
    {
        private int idade;
        private string numero;
        private string nome = string.Empty;
        private string cargo = string.Empty;
        private string foto;

        public Funcionario(int idade,  string numero, string nome, string cargo, string foto)
        {
            this.idade = idade;
            this.numero = numero;
            this.nome = nome;
            this.cargo = cargo;
            this.foto = foto;
        }
        public string GetNome()
        {
            return nome;
        }
        public string Getnumero(string numero)
        {
            return numero;
        }
        public int Getidade(int idade)
        {
            return idade;
        }
        
        public string Getcargo()
        {
            return cargo;
        }
        public void Getnome(string nome)
        {
            this.nome = nome;
        }

        public void Getfoto(string foto) 
        {
            this.foto = foto;
        
        }
      
      
       
        public virtual void Visualizar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "\n*************************************************\n" +
                "\n     AQUI ESTÁ INFORMAÇÕES DE SEU REGISTRO \n" +
                "\n*************************************************\n" +
                $"\nNome : {this.nome}" +
                $"\nSua Idade: {this.idade}" +
                $"\nSeu Codigo Interno : {this.numero}" +
                $"\nCargo Atual: {this.cargo}" +
                $"\nFoto: {this.foto}" +
                "\n*************************************************\n");
               
        }
    }
}
