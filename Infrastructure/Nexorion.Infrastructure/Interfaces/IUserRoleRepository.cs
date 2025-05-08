using Nexorion.Core.Models;

namespace Infrastructure.Interfaces
{
    public interface IUserRoleRepository
    {
        Task AssignRoleAsync(Guid userId, Guid roleId);
        Task RemoveRoleAsync(Guid userId, Guid roleId);
        Task<IEnumerable<Role>> GetRolesByUserIdAsync(Guid userId);
    }
}