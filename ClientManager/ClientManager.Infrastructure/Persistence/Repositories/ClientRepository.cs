using ClienteManager.Core.Entities;
using ClienteManager.Core.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClientManager.Infrastructure.Persistence.Repositories
{
    public class ClientRepository : IClienteRepository
    {
        private readonly ClientManagerDbContext _dbContext;

        public ClientRepository(ClientManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Cliente>> GetAllAsync()
        {
            return await _dbContext.Clients.ToListAsync();
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
            return await _dbContext.Clients.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddAsync(Cliente cliente)
        {
            await _dbContext.Clients.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Cliente cliente)
        {
            _dbContext.Clients.Remove(cliente);
            await _dbContext.SaveChangesAsync();
        }
        
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}   
