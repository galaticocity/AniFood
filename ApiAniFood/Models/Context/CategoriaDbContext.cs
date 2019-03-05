using Microsoft.EntityFrameworkCore;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Models.Context
{
    public class CategoriaDbContext : DbContext
    {
        public CategoriaDbContext(DbContextOptions<CategoriaDbContext> options) : base(options)
        {
            
        }

        public DbSet<Categoria> Categoria { get; set; }
    }
}