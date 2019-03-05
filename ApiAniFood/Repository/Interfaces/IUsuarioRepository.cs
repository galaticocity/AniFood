using System.Collections.Generic;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
         Usuario Find(string nome);
         Usuario FindById(int id);
         IEnumerable<Usuario> FindByStatus(char status);
         Usuario Add(Usuario usuario);
         Usuario Update(Usuario usuario);
         Usuario Remove(string nome);
         Usuario RemoveById(int id);
    }
}