using Farmacia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Repository
{
    // responsavel por desaclopar e nao ficar refem da classes cridas
    public interface Ifarmaciarepository 
    {
        public void ProcurarPornumero(int id);
        public void ListarTodososProdutos();
        public void Cadastrar(Produto produto); // eu preciso variavel pra guardar as informações.
        public void AtualizarProduto(Produto produto);

        public void DeletarProduto (int id);
       
    }
}
