
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Interfaces;
using Nexorion.Core.Models;

[ApiController]
[Route("api/user-roles")]
public class UserRoleController : ControllerBase
{
    private readonly IUserRoleRepository _repo;

    public UserRoleController(IUserRoleRepository repo) => _repo = repo;

    [HttpPost("assign")]
    public async Task<IActionResult> Assign([FromQuery] Guid userId, [FromQuery] Guid roleId)
    {
        await _repo.AssignRoleAsync(userId, roleId);
        return Ok();
    }

    [HttpPost("remove")]
    public async Task<IActionResult> Remove([FromQuery] Guid userId, [FromQuery] Guid roleId)
    {
        await _repo.RemoveRoleAsync(userId, roleId);
        return Ok();
    }

    [HttpGet("{userId}/roles")]
    public async Task<IEnumerable<Role>> GetRoles(Guid userId)
    {
        return await _repo.GetRolesByUserIdAsync(userId);
    }
}
