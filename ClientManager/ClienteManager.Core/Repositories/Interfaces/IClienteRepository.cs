
using ClienteManager.Core.Entities;

namespace ClienteManager.Core.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetAllAsync();
        Task<Cliente> GetByIdAsync(int id);
        Task AddAsync(Cliente cliente);
        Task DeleteAsync(Cliente cliente);
        Task SaveChangesAsync();
    }
}
