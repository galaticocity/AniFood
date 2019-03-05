using Microsoft.EntityFrameworkCore;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Models.Context
{
    public class ProdutoDbContext : DbContext
    {
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options)
        {
            
        }        
        public DbSet<Produto> Produto { get; set; }
    }
}