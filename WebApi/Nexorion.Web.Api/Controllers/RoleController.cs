
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Interfaces;
using Nexorion.Core.Models;

[ApiController]
[Route("api/roles")]
public class RoleController : ControllerBase
{
    private readonly IRoleRepository _repo;

    public RoleController(IRoleRepository repo) => _repo = repo;

    [HttpGet("all")]
    public async Task<IEnumerable<Role>> Get() => await _repo.GetAllAsync();

    [HttpGet("{id}")]
    public async Task<Role> GetById(Guid id) => await _repo.GetByIdAsync(id);

    [HttpPost("create")]
    public async Task<IActionResult> Post([FromBody] Role role)
    {
        await _repo.InsertAsync(role);
        return Ok();
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] Role role)
    {
        role.Id = id;
        await _repo.UpdateAsync(role);
        return Ok();
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var role = await _repo.GetByIdAsync(id);
        if (role == null)
        {
            return NotFound();
        }
        role.IsDeleted = true;
        await _repo.UpdateAsync(role);
        return Ok();
    }
}
