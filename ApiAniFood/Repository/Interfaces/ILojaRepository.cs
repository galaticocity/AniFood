using System.Collections.Generic;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Repository.Interfaces
{
    public interface ILojaRepository
    {
         IEnumerable<Loja> GetAll();
         Loja FindById(int id);
         void Add(Loja loja);
         void RemoveById(int id);
         void Update(Loja loja);
    }
}