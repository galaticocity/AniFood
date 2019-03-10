using System.Collections.Generic;
using System.Linq;
using ApiAniFood.Models.Class;
using ApiAniFood.Models.Context;
using ApiAniFood.Repository.Interfaces;

namespace ApiAniFood.Repository.Class
{
    public class PedidoProdutoRepository : IPedidoProdutoRepository
    {
        private readonly PedidoProdutoDbContext _context;
        public PedidoProdutoRepository(PedidoProdutoDbContext context)
        {
            _context = context;
        }
        public void Add(PedidoProduto pedidoProduto)
        {
            _context.PedidoProduto.Add(pedidoProduto);
            _context.SaveChanges();
        }

        public PedidoProduto FindById(int id)
        {
            return _context.PedidoProduto.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<PedidoProduto> GetAll()
        {
            return _context.PedidoProduto.ToList();
        }

        public void RemoveById(int id)
        {
            var pedidoProduto = _context.PedidoProduto.First(x => x.ID == id);
            _context.PedidoProduto.Remove(pedidoProduto);
            _context.SaveChanges();
        }
    }
}