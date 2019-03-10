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

        public void Add(Aluno aluno)
        {
            _context.Aluno.Add(aluno);
            _context.SaveChanges();
        }

        public Aluno Find(string ra)
        {
            return _context.Aluno.FirstOrDefault(x => x.RA == ra);
        }

        public Aluno Login(string ra, string senha)
        {
            return _context.Aluno.FirstOrDefault(x => x.RA == ra && x.Senha == senha);
        }

        public void Remove(string ra)
        {
            var aluno = _context.Aluno.First(x => x.RA == ra);
            _context.Aluno.Remove(aluno);
            _context.SaveChanges();
        }

        public void Update(Aluno aluno)
        {
            _context.Aluno.Update(aluno);
            _context.SaveChanges();
        }
    }
}