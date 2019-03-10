using System.Collections.Generic;
using System.Linq;
using ApiAniFood.Models.Class;
using ApiAniFood.Models.Context;
using ApiAniFood.Repository.Interfaces;

namespace ApiAniFood.Repository.Class
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContext _context;
        public UsuarioRepository(UsuarioDbContext context)
        {
            _context = context;
        }
        public void Add(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public Usuario Find(string nome)
        {
            return _context.Usuario.FirstOrDefault(x => x.Nome == nome);
        }

        public Usuario FindById(int id)
        {
            return _context.Usuario.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Usuario> FindByStatus(char status)
        {
            return _context.Usuario.Where(x => x.StatusUsuario == status);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuario.ToList();
        }

        public void Remove(string nome)
        {
            var usuario = _context.Usuario.First(x => x.Nome == nome);
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }

        public void RemoveById(int id)
        {
            var usuario = _context.Usuario.First(x => x.ID == id);
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _context.Usuario.Update(usuario);
            _context.SaveChanges();
        }
    }
}