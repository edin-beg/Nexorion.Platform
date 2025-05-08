using Nexorion.Core.Models;

namespace Infrastructure.Interfaces
{
    public interface ITenantRepository : IRepository<Tenant>
    {
        Task<Tenant> GetByCodeAsync(string code);
    }
}