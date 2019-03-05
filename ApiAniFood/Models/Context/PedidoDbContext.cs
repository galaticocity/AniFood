using Microsoft.EntityFrameworkCore;
using ApiAniFood.Models.Class;

namespace ApiAniFood.Models.Context
{
    public class PedidoDbContext : DbContext
    {
        public PedidoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Pedido> Pedido { get; set; }
    }
}