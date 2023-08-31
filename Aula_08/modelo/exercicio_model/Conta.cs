using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace modelo.exercicio_model
{
    internal class Conta
    {
    
       

            private int idade;
            private int cpf;
            private string endereco = string.Empty;
            private string nome = string.Empty;
            private string email = string.Empty;    

        public Conta(int idade, int cpf, string endereco, string nome, string email)
        {
            this.idade = idade;
            this.cpf = cpf;
            this.endereco = endereco;
            this.nome = nome;
            this.email = email;
        }
        public string getNome()
        {
            return nome;
        }
        public int getCpf()
        {
            return cpf;
        }
        public int getidade()
        {
            return idade;
        }
        public string getemail()
        {
            return email;
        }
        public string getendereco()
        {
            return endereco;
        }

        
       
        public void setnome(string nome)
        {
            this.nome = nome;
        }
        public void setcpf(int cpf )
        {
            this.cpf = cpf;
        }
        public void setidade(int idade)
        {
            this.idade = idade;
        }
        public void setemail(string email)
        {
            this.email = email;
        }

       

        public void Visualizar()
        {
           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "\n*************************************************\n" +
                "\n     AQUI ESTÁ INFORMAÇÕES DA SUA CONTA\n" +
                "\n*************************************************\n" +
                $"\nNome : {this.nome}" +
                $"\nSua Idade: {this.idade }" +
                $"\nCPF :{this.cpf}" +
                $"\nEndereço cadastrado: {this.endereco}" +
                $"\nSeu Email: {this.email}" +
                "\n*************************************************\n");
        }












    }

}
