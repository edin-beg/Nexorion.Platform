using Nexorion.Core.Models;

namespace Infrastructure.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByUsernameAsync(string username);
        Task<IEnumerable<User>> GetByTenantIdAsync(Guid tenantId);
    }
}