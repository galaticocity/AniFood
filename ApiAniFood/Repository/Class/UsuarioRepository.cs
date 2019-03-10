using System.Collections.Generic;
using ApiAniFood.Models.Class;
using ApiAniFood.Repository.Interfaces;

namespace ApiAniFood.Repository.Class
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario Add(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Find(string nome)
        {
            throw new System.NotImplementedException();
        }

        public Usuario FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Usuario> FindByStatus(char status)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Remove(string nome)
        {
            throw new System.NotImplementedException();
        }

        public Usuario RemoveById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}