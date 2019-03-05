using Microsoft.EntityFrameworkCore;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Models.Context
{
    public class AlunoDbContext :DbContext
    {
        public AlunoDbContext(DbContextOptions<AlunoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> Aluno {get; set;} 
    }
}