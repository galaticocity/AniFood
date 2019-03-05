using System.Collections.Generic;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Repository.Interfaces 
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto Find (string nome);
        Produto FindById (int id);
        IEnumerable<Produto> FindByValor(decimal valor);
        IEnumerable<Produto> FindByStatus(char status);
        Produto Add (Produto produto);
        Produto Update (Produto produto);
        Produto Remove (string nome);
        Produto RemoveById (int id);

    }
}