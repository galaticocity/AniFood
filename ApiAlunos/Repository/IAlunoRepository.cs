using System.Collections.Generic;
using ApiAlunos.Models;

namespace ApiAlunos.Repository
{
    public interface IAlunoRepository
    {
        IEnumerable<Aluno> GetAll();
        Aluno Find(string ra);
        Aluno Login(string ra, string senha);
    }
}