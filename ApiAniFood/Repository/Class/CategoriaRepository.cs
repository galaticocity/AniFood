using System.Collections.Generic;
using System.Linq;
using ApiAniFood.Models.Class;
using ApiAniFood.Models.Context;
using ApiAniFood.Repository.Interfaces;

namespace ApiAniFood.Repository.Class
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly CategoriaDbContext _context;
        public CategoriaRepository(CategoriaDbContext context)
        {
            _context = context;
        }

        public void Add(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
        }

        public Categoria Find(string nome)
        {
            return _context.Categoria.FirstOrDefault(x => x.Nome == nome);
        }

        public Categoria FindById(int id)
        {
            return _context.Categoria.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _context.Categoria.ToList();
        }

        public void Remove(string nome)
        {
            var result = _context.Categoria.First(x => x.Nome == nome);
            _context.Categoria.Remove(result);
            _context.SaveChanges();

        }

        public void RemoveById(int id)
        {
            var result = _context.Categoria.First(x => x.ID == id);
            _context.Categoria.Remove(result);
            _context.SaveChanges();
        }

        public void Update(Categoria categoria)
        {
            _context.Categoria.Update(categoria);
            _context.SaveChanges();
        }
    }
}