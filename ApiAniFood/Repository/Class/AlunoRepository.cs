using System.Linq;
using ApiAniFood.Models.Class;
using ApiAniFood.Models.Context;
using ApiAniFood.Repository.Interfaces;

namespace ApiAniFood.Repository.Class
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AlunoDbContext _context;

        public AlunoRepository(AlunoDbContext context)
        {
            _context = context;
        }
        public Aluno Add(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Aluno Find(string ra)
        {
            throw new System.NotImplementedException();
        }

        public Aluno Login(string ra, string senha)
        {
            return _context.Aluno.FirstOrDefault(x => x.RA == ra && x.Senha == senha);
        }

        public Aluno Remove(int ra)
        {
            throw new System.NotImplementedException();
        }

        public Aluno Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}