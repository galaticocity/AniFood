using System.Collections.Generic;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Repository.Interfaces
{
    public interface IPedidoProdutoRepository
    {
         IEnumerable<PedidoProduto> GetAll();
         PedidoProduto FindById(int id);
         void Add(PedidoProduto pedidoProduto);
         void RemoveById(int id);
    }
}