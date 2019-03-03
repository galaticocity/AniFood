using Microsoft.EntityFrameworkCore;

namespace ApiAlunos.Models
{
    public class AlunoDbContext : DbContext
    {
        public AlunoDbContext(DbContextOptions<AlunoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> Aluno {get; set;}
    }
}