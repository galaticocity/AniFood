using System.Collections.Generic;
using System.Linq;
using ApiAniFood.Models.Class;
using ApiAniFood.Models.Context;
using ApiAniFood.Repository.Interfaces;

namespace ApiAniFood.Repository.Class
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoDbContext _context;
        public ProdutoRepository(ProdutoDbContext context)
        {
            _context = context;
        }

        public void Add(Produto produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
        }

        public IEnumerable<Produto> Find(string nome)
        {
            return _context.Produto.Where(x => x.Nome.Contains(nome)).ToList();
        }

        public Produto FindById(int id)
        {
            return _context.Produto.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Produto> FindByStatus(char status)
        {
            return _context.Produto.Where(x => x.StatusProduto == status);
        }

        public IEnumerable<Produto> FindByValor(double valor)
        {
            return _context.Produto.Where(x => x.Valor == valor).ToList();
        }

        public IEnumerable<Produto> FindByValorGraterThan(double valor)
        {
            return _context.Produto.Where(x => x.Valor >= valor).ToList();
        }

        public IEnumerable<Produto> FindByValorLessThan(double valor)
        {
            return _context.Produto.Where(x => x.Valor <= valor).ToList();
        }

        public IEnumerable<Produto> FindProdutoByLanchoneteId(int id)
        {
            return _context.Produto.Where(x => x.IdLoja == id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Produto.ToList();
        }

        public void Remove(string nome)
        {
            var produto = _context.Produto.FirstOrDefault(x => x.Nome == nome);
            _context.Produto.Remove(produto);
            _context.SaveChanges(); 
        }

        public void RemoveById(int id)
        {
            var produto = _context.Produto.FirstOrDefault(x => x.ID == id);
            _context.Produto.Remove(produto);
            _context.SaveChanges();    
        }

        public void Update(Produto produto)
        {
            _context.Produto.Update(produto);
            _context.SaveChanges(); 
        }
    }
}