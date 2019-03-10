using System.Collections.Generic;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Repository.Interfaces 
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        IEnumerable<Produto> Find(string nome);
        Produto FindById (int id);
        IEnumerable<Produto> FindByValor(double valor);
        IEnumerable<Produto> FindByValorLessThan(double valor);
        IEnumerable<Produto> FindByValorGraterThan(double valor);
        IEnumerable<Produto> FindByStatus(char status);
        void Add (Produto produto);
        void Update (Produto produto);
        Produto Remove (string nome);
        void RemoveById (int id);

    }
}