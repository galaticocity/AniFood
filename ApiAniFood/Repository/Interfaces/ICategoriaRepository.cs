using System.Collections.Generic;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
         Categoria Find(string nome);
         Categoria FindById(int id);
         IEnumerable<Categoria> GetAll();
         void Add(Categoria categoria);
         void Update(Categoria categoria);
         void Remove(string nome);
         void RemoveById(int id);
    }
}