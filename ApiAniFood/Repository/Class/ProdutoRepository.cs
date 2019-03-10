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
            throw new System.NotImplementedException();
        }

        public IEnumerable<Produto> FindByValor(double valor)
        {
            return _context.Produto.Where(x => x.Valor == valor).ToList();
        }

        public IEnumerable<Produto> FindByValorGraterThan(double valor)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Produto> FindByValorLessThan(double valor)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Produto.ToList();
        }

        public Produto Remove(string nome)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Produto produto)
        {
            throw new System.NotImplementedException();
        }
    }
}