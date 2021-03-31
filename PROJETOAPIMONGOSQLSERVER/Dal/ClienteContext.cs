using PROJETOAPIMONGOSQLSERVER.Models;
using Microsoft.EntityFrameworkCore;

namespace PROJETOAPIMONGOSQLSERVER.Dal
{
    public class ClienteContext : DbContext
    {
        
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {}
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
            .HasOne(b => b.Endereco);
            base.OnModelCreating(modelBuilder);
        }


    
    }
}