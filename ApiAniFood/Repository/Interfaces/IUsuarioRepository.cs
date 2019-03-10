using System.Collections.Generic;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> GetAll();
         Usuario Find(string nome);
         Usuario FindById(int id);
         IEnumerable<Usuario> FindByStatus(char status);
         void Add(Usuario usuario);
         void Update(Usuario usuario);
         void Remove(string nome);
         void RemoveById(int id);
    }
}