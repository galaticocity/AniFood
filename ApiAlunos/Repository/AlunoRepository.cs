using System.Collections.Generic;
using System.Linq;
using ApiAlunos.Models;

namespace ApiAlunos.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AlunoDbContext _context;

        public AlunoRepository(AlunoDbContext context)
        {
            _context = context;
        }
        public Aluno Find(string ra)
        {
            return _context.Aluno.FirstOrDefault(x => x.RA == ra);
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _context.Aluno.ToList();
        }

        public Aluno Login(string ra, string senha)
        {
            return _context.Aluno.FirstOrDefault(x => x.RA == ra && x.Senha == senha);
        }
    }
}