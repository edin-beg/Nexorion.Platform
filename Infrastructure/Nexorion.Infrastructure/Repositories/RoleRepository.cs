using Infrastructure.Interfaces;
using Nexorion.Core.Models;
using NPoco;

namespace Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IDatabase _db;

        public RoleRepository(IDatabase db)
        {
            _db = db;
        }

        public async Task<Role> GetByIdAsync(Guid id) => await _db.SingleOrDefaultAsync<Role>("WHERE id = @0", id);

        public async Task<IEnumerable<Role>> GetAllAsync() => await _db.FetchAsync<Role>();

        public async Task InsertAsync(Role entity) => await _db.InsertAsync(entity);

        public async Task UpdateAsync(Role entity) => await _db.UpdateAsync(entity);

        public async Task<IEnumerable<Role>> GetByTenantIdAsync(Guid tenantId) => await _db.FetchAsync<Role>("WHERE tenant_id = @0", tenantId);
    }
}
