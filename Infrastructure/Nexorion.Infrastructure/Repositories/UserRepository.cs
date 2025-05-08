using Infrastructure.Interfaces;
using Nexorion.Core.Models;
using NPoco;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDatabase _db;

        public UserRepository(IDatabase db)
        {
            _db = db;
        }

        public async Task<User> GetByIdAsync(Guid id) => await _db.SingleOrDefaultAsync<User>("WHERE id = @0", id);

        public async Task<IEnumerable<User>> GetAllAsync() => await _db.FetchAsync<User>();

        public async Task InsertAsync(User entity) => await _db.InsertAsync(entity);

        public async Task UpdateAsync(User entity) => await _db.UpdateAsync(entity);

        public async Task<User> GetByUsernameAsync(string username) => await _db.SingleOrDefaultAsync<User>("WHERE username = @0", username);

        public async Task<IEnumerable<User>> GetByTenantIdAsync(Guid tenantId) => await _db.FetchAsync<User>("WHERE tenant_id = @0", tenantId);
    }
}
