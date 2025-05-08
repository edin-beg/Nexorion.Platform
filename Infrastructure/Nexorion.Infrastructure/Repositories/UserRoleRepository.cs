using Infrastructure.Interfaces;
using Nexorion.Core.Models;
using NPoco;

namespace Infrastructure.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly IDatabase _db;

        public UserRoleRepository(IDatabase db)
        {
            _db = db;
        }

        public async Task AssignRoleAsync(Guid userId, Guid roleId)
        {
            await _db.InsertAsync("user_roles", "user_id", new { user_id = userId, role_id = roleId });
        }


        public async Task RemoveRoleAsync(Guid userId, Guid roleId)
        {
            await _db.ExecuteAsync("DELETE FROM user_roles WHERE user_id = @0 AND role_id = @1", userId, roleId);
        }

        public async Task<IEnumerable<Role>> GetRolesByUserIdAsync(Guid userId)
        {
            return await _db.FetchAsync<Role>(@"
                SELECT r.* FROM roles r
                INNER JOIN user_roles ur ON ur.role_id = r.id
                WHERE ur.user_id = @0", userId);
        }
    }
}
