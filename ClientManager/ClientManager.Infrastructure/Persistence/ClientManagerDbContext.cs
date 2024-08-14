using ClienteManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ClientManager.Infrastructure.Persistence
{
    public class ClientManagerDbContext : DbContext
    {
        public ClientManagerDbContext(DbContextOptions<ClientManagerDbContext> options) : base(options)
        {
            
        }
        public DbSet<Cliente> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
