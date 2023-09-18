using Farmacia.Model;
using Farmacia.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Farmacia.Controller
{
    public class FarmaController : Ifarmaciarepository
        
    {
        private readonly List<Produto> listaprodutos= new();
        int id = 0;
        
        public void AtualizarProduto(Produto produto)
        {
            var buscaProduto = BuscarNaCollection(produto.Id);

            if (produto != null)
            {  // com o index eu pego a aonde a conta esta. 
                var index = listaprodutos.IndexOf(buscaProduto);
                // parte que sera feita atualização da conta
                listaprodutos[index] = produto;

                Console.WriteLine("O Produto foi foi atualizado com sucesso");

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A conta numero não foi encontrado");
                Console.ResetColor();
            }
        }

        public void Cadastrar(Produto produto)
        {
            listaprodutos.Add(produto);
          
        }

        public void DeletarProduto(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto != null)
            {
                if (listaprodutos.Remove(produto) == true)
                    Console.WriteLine($"O produto {id} foi apagada com Sucesso");
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A produto não foi encontrado");
                Console.ResetColor();
            }

        }

        public void ListarTodososProdutos()
        {
            
                foreach (var produto in listaprodutos)
                {
                    produto.Visualizar();
                }
            
        }

        public void ProcurarPornumero(int id)
        {

            var produto = BuscarNaCollection(id);

            if (produto != null)
                produto.Visualizar();
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta numero {id} não foi encontrado:");
                Console.ResetColor();
            }
        }


        public int Gerarid()
        {

            return ++id;
        }

        // met0do de busca especifica dentro da classe conta
        public Produto? BuscarNaCollection(int id)
        {
            foreach (var produto in listaprodutos)
            {
                if (produto.Id == id) 
                {
                    return produto;
                }

            }
            return null;// minha assinatura nao esta com o ?, onde o objeto pode vim nulo, entao é so colocar o ? na frente da assinatura
        }


    }

}






