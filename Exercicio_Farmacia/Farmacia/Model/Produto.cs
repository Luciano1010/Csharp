using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public abstract class Produto
    {

        // modo simplificado dos modos get e set
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Tipo { get; set; }
        public decimal Preco { get; set; }



        protected Produto(int id, string nome, int tipo, decimal preco)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            Preco = preco;
        }

        public virtual void Visualizar()
        {


            Console.WriteLine("\n\n*********************************************************************");
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine($"Id do Produto: " + Id);
            Console.WriteLine($"Nome do Produto: " + Nome);
            Console.WriteLine($"Tipo do Prodto: "+ Tipo);
            Console.WriteLine($"Preço do Produto: " + Preco);
            
        }




    }
}


