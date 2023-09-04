using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace modelo.exercicio_model
{
   public class Conta
    {
            
       
        // atrubutos 
            private string telefone;
            private int id; // Cpf ou Cnpj
            private string endereco = string.Empty;
            private string nome = string.Empty;
            private string email = string.Empty; 
            private string tipo;
            

        public Conta(string telefone, int id, string endereco, string nome, string email, string tipo)
        {
            this.telefone = telefone;
            this.id = id;
            this.endereco = endereco;
            this.nome = nome;
            this.email = email;
            this.tipo = tipo;
        }
        public string getNome()
        {
            return nome;
        }
        public int getid()
        {
            return id;
        }
        public string getelefone()
        {
            return telefone;
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
        public void setid(int id )
        {
            this.id = id;
        }
        public void settelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public void setemail(string email)
        {
            this.email = email;
        }

       

        public virtual void Visualizar()
        {
          
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(
                "\n*************************************************\n" +
                "\n     AQUI ESTÁ INFORMAÇÕES DA SUA CONTA\n" +
                "\n*************************************************\n" +
                $"\nNome : {this.nome}" +
                $"\nSua telefone: {this.telefone }" +
                $"\nTipo de Conta :{this.id}" +
                $"\nEndereço cadastrado: {this.endereco}" +
                $"\nSeu Email: {this.email}" +
                "\n*************************************************\n");
        }












    }

}
