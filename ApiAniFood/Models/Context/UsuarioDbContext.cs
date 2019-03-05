using ApiAniFood.Models.Class;
using Microsoft.EntityFrameworkCore;

namespace ApiAniFood.Models.Context {
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext (DbContextOptions<UsuarioDbContext> options) : base (options) {

        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}