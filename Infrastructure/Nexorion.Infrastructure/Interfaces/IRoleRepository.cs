using Nexorion.Core.Models;

namespace Infrastructure.Interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        Task<IEnumerable<Role>> GetByTenantIdAsync(Guid tenantId);
    }
}