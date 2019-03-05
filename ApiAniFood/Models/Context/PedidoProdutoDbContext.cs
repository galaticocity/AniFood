using Microsoft.EntityFrameworkCore;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Models.Context
{
    public class PedidoProdutoDbContext : DbContext
    {
        public PedidoProdutoDbContext(DbContextOptions<PedidoProdutoDbContext> options) : base(options)
        {
            
        }
        public DbSet<PedidoProduto> PedidoProduto { get; set; }
    }
}