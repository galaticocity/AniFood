
using ApiAniFood.Models.Class;
using Microsoft.EntityFrameworkCore;

namespace ApiAniFood.Models.Context
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext(DbContextOptions<LojaDbContext> options) : base(options)
        {

        }

        public DbSet<Loja> Loja {get; set;}
    }
}