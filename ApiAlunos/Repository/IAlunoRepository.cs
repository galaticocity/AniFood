using System.Collections.Generic;
using ApiAlunos.Models;

namespace ApiAlunos.Repository
{
    public interface IAlunoRepository
    {
        IEnumerable<Aluno> GetAll();
        Aluno find(string ra);
        Aluno login(string ra, string senha);
    }
}