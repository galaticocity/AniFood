using ApiAniFood.Models.Class;

namespace ApiAniFood.Repository.Interfaces
{
    public interface IAlunoRepository
    {
         Aluno Find(string ra);
         Aluno Add(Usuario usuario);
         Aluno Update(Usuario usuario);
         Aluno Remove(int ra);

         Aluno Login(string ra, string senha);
    }
}