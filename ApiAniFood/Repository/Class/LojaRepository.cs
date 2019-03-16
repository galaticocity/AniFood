using System.Collections.Generic;
using System.Linq;
using ApiAniFood.Models.Class;
using ApiAniFood.Models.Context;
using ApiAniFood.Repository.Interfaces;

namespace ApiAniFood.Repository.Class
{
    public class LojaRepository : ILojaRepository
    {
        private readonly LojaDbContext _context;
        public LojaRepository(LojaDbContext context)
        {
            _context = context;
        }
        public void Add(Loja loja)
        {
            _context.Loja.Add(loja);
            _context.SaveChanges();
        }

        public Loja FindById(int id)
        {
            return _context.Loja.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Loja> GetAll()
        {
            return _context.Loja.ToList(); 
        }

        public void RemoveById(int id)
        {
            var loja = _context.Loja.FirstOrDefault(x => x.ID == id);
            _context.Remove(loja);
            _context.SaveChanges();
        }

        public void Update(Loja loja)
        {
            _context.Loja.Update(loja);
            _context.SaveChanges();
        }
    }
}