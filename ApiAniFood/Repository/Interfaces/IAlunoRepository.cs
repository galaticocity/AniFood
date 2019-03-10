using ApiAniFood.Models.Class;

namespace ApiAniFood.Repository.Interfaces
{
    public interface IAlunoRepository
    {
         Aluno Find(string ra);
         void Add(Aluno aluno);
         void Update(Aluno aluno);
         void Remove(string ra);

         Aluno Login(string ra, string senha);
    }
}