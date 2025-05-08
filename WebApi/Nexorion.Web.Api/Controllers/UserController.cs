
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Interfaces;
using Nexorion.Core.Models;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repo;

    public UserController(IUserRepository repo) => _repo = repo;

    [HttpGet("all")]
    public async Task<IEnumerable<User>> Get() => await _repo.GetAllAsync();

    [HttpGet("{id}")]
    public async Task<User> GetById(Guid id) => await _repo.GetByIdAsync(id);

    [HttpPost("create")]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        await _repo.InsertAsync(user);
        return Ok();
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] User user)
    {
        user.Id = id;
        await _repo.UpdateAsync(user);
        return Ok();
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var user = await _repo.GetByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }
        user.IsDeleted = true;
        await _repo.UpdateAsync(user);
        return Ok();
    }
}
