using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_model2.model2
{
    internal class Conta2
    {
        private int idade;
        private string cpf = string.Empty;
        private int numero;
        private string nome = string.Empty;
        private string cargo = string.Empty;

        public Conta2(int idade, string cpf, int numero , string nome, string cargo)
        {
            this.idade = idade;
            this.cpf = cpf;
            this.numero = numero;
            this.nome = nome;
            this.cargo = cargo;
        }
        public string getNome()
        {
            return nome;
        }
        public string getCpf()
        {
            return cpf;
        }
        public int getidade()
        {
            return idade;
        }
        public int getnumero()
        {
            return numero;
        }
        public string getcargo()
        {
            return cargo;
        }



        public void setnome(string nome)
        {
            this.nome = nome;
        }
        public void setcpf(string cpf)
        {
            this.cpf = cpf;
        }
        public void setidade(int idade)
        {
            this.idade = idade;
        }
        public void setnumero(int numero)
        {
            this.numero = numero;
        }



        public void Visualizar()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "\n*************************************************\n" +
                "\n     AQUI ESTÁ INFORMAÇÕES DA SUA CONTA\n" +
                "\n*************************************************\n" +
                $"\nNome : {this.nome}" +
                $"\nSua Idade: {this.idade}" +
                $"\nCPF :{this.cpf}" +
                $"\nSeu Codigo Interno : {this.numero}" +
                $"\nCargo Atual: {this.cargo}" +
                "\n*************************************************\n");
        }






    }
}
